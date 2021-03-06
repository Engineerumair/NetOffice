using System;
using NetOffice;
namespace NetOffice.ADODBApi.Enums
{
	 /// <summary>
	 /// SupportByVersion ADODB 2.1, 2.5
	 /// </summary>
	[SupportByVersionAttribute("ADODB", 2.1,2.5)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum PositionEnum
	{
		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByVersionAttribute("ADODB", 2.1,2.5)]
		 adPosUnknown = -1,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>-2</remarks>
		 [SupportByVersionAttribute("ADODB", 2.1,2.5)]
		 adPosBOF = -2,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>-3</remarks>
		 [SupportByVersionAttribute("ADODB", 2.1,2.5)]
		 adPosEOF = -3
	}
}