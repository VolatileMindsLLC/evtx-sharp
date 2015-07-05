using System;
using System.IO;

namespace evtxsharp
{
	public class _x04 : INode
	{
		private _x04 (){}
		
		public _x04 (BinaryReader reader, long chunkOffset, LogRoot root, INode parent)
		{
			this.Position = reader.BaseStream.Position;
			this.LogRoot = root;
			root.TagState = 0;
			this.SelfEnclosed = true;
			this.Parent = parent;
		}
		
		#region INode implementation
		public INode Parent { get; set; }
		public long Position { get; set; }
		public string String { get; set; }
		public int SubstitutionArray { get; set; }
		public bool SelfEnclosed { get; set; }
		
		public long ChunkOffset { get; set; }
		public LogRoot LogRoot { get; set; }
		public string ToXML()
		{	
			return "</" + this.Parent.String + ">";
		}
		public long Length 
		{
			get
			{
				return 1;
			}
			
			set {}
		}
		#endregion
	}
}

