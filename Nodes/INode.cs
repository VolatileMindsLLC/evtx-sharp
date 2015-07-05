using System;
using System.IO;

namespace evtxsharp
{
	public interface INode
	{
		INode Parent { get; set; }
		
		long Position { get; set; }
		
		long ChunkOffset { get; set; }
		
		long Length { get; set; }
		
		bool SelfEnclosed { get; set; }
		
		string String { get; set; }
		
		
		string ToXML();
	}
}

