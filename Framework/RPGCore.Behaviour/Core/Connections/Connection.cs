﻿using System;
using System.Diagnostics;

namespace RPGCore.Behaviour
{
	public class Connection
	{
		public event Action OnAfterChanged;

		protected void InvokeAfterChanged ()
		{
			OnAfterChanged?.Invoke ();
		}
	}

	public class Connection<T> : Connection
	{
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		private T internalValue;

		public T Value
		{
			get => internalValue;
			set
			{
				internalValue = value;
				InvokeAfterChanged ();
			}
		}

		public override string ToString () => $"Connection, Value = {internalValue}";
	}
}
