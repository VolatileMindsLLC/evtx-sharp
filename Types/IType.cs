using System;

namespace evtxsharp
{
	public interface IType
	{
		int Length { get; set; }
		
		string String { get; set; }
	}
}

