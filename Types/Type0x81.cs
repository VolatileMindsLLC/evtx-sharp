using System;
using System.IO;

namespace evtxsharp
{
	public class Type0x81 : IType
	{
		public Type0x81 (BinaryReader log, int size)
		{
			throw new NotSupportedException();
		}
		
		public string String { get; set; }
		#region IType implementation
		public byte Type {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public int Length {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}
		#endregion
	}
}

