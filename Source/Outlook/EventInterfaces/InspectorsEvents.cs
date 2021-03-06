using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;

namespace NetOffice.OutlookApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15,16)]
	[ComImport, Guid("00063079-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface InspectorsEvents
	{
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15,16)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61441)]
		void NewInspector([In, MarshalAs(UnmanagedType.IDispatch)] object inspector);
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class InspectorsEvents_SinkHelper : SinkHelper, InspectorsEvents
	{
		#region Static
		
		public static readonly string Id = "00063079-0000-0000-C000-000000000046";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public InspectorsEvents_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region Properties

        internal Core Factory
        {
            get
            {
                if (null != _eventClass)
                    return _eventClass.Factory;
                else
                    return Core.Default;
            }
        }

        #endregion

		#region InspectorsEvents Members
		
		public void NewInspector([In, MarshalAs(UnmanagedType.IDispatch)] object inspector)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("NewInspector");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(inspector);
				return;
			}

			NetOffice.OutlookApi._Inspector newInspector = Factory.CreateObjectFromComProxy(_eventClass, inspector) as NetOffice.OutlookApi._Inspector;
			object[] paramsArray = new object[1];
			paramsArray[0] = newInspector;
			_eventBinding.RaiseCustomEvent("NewInspector", ref paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}