using System;
using System.IO;

namespace evtxsharp
{
	public class _x07 : INode
	{
		private _x07 (){}
		
		public _x07 (BinaryReader log, long chunkOffset, LogRoot root, INode parent)
		{
			this.Position = log.BaseStream.Position;
			short length = log.ReadInt16();	
			this.SelfEnclosed = true;
			
			this.LogRoot = root;
		}
		
		#region INode implementation
		public INode Parent { get; set; }
		public long Position { get; set; }
		public long ChunkOffset { get; set; }
		public string String { get; set; }
		public int SubstitutionArray { get; set; }
		public LogRoot LogRoot { get; set; }
		
		public bool SelfEnclosed { get; set; }
		
		public string ToXML() { throw new Exception(); }
		public long Length 
		{
			get
			{
				throw new Exception();
			}
			
			set {}
		}
		#endregion
	}
}

