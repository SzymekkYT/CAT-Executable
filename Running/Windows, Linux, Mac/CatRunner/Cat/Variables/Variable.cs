﻿namespace CatRunner.Cat.Variables
{
	public class Variable
	{
		public object Value { get; set; }
		public VarType Type;
	}
	public enum VarType { Bool, Byte, Short, UShort, Int, UInt, Long, ULong, Float, Double, String }
}
