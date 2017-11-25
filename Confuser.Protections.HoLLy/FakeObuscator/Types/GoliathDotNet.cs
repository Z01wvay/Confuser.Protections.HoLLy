﻿using System;
using System.Collections.Generic;
using System.Reflection;
using dnlib.DotNet;

namespace Confuser.Protections.HoLLy.FakeObuscator.Types
{
	internal class GoliathDotNet
	{
		public static TypeDefUser GetAttributes() => new TypeDefUser("ObfuscatedByGoliath");
		public static Type GetTypes() => typeof(GoliathStrongNameChecker);

        //no fields, no events, no properties
		internal class GoliathStrongNameChecker
		{
            //has throw instruction
		    public static void AntiTamper(Type t)
		    {
		        //required locals
		        var l1 = default(Assembly);
		        var l2 = default(Stack<int>);

				//this gets boring after a while, you know
				var party = new Exception();
			    throw party;
		    }

			public byte[] RequiredMethod(Assembly s) => default(byte[]);
			public string RequiredMethod(Stack<int> s) => default(string);
			public int RequiredMethod(int i, byte[] b) => default(int);
		}
	}
}
