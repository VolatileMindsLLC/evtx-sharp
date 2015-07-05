using System;
using System.IO;

namespace evtxsharp
{
	public class _x0D : INode
	{
		private _x0D (){}
		
		public _x0D (BinaryReader log, long chunkOffset, LogRoot root, INode parent)
		{
			this.Position = log.BaseStream.Position;
			short index = log.ReadInt16();
			byte type = log.ReadByte();
			this.LogRoot = root;
			this.SelfEnclosed = true;
	}
		
		#region INode implementation
		public INode Parent { get; set; }
		public long Position { get; set; }
		public string String { get; set; }
		public bool SelfEnclosed { get; set; }
		
		public long ChunkOffset { get; set; }
		public int SubstitutionArray { get; set; }
		public LogRoot LogRoot { get; set; }
		public string ToXML() { return "<0x0d>"; }
		
		public long Length { 
			get
			{
				return 4;
			}
			set {}
		}
		#endregion
	}
}

