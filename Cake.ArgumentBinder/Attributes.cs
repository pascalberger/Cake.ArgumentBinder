﻿//
// Copyright Seth Hendrick 2019.
// Distributed under the MIT License.
// (See accompanying file LICENSE in the root of the repository).
//

using System;

namespace Cake.ArgumentBinder
{
    [AttributeUsage( AttributeTargets.Property, Inherited = true, AllowMultiple = false )]
    public class StringArgumentAttribute : BaseStringAttribute
    {
        // ---------------- Constructor ----------------

        public StringArgumentAttribute( string arg ):
            base( arg )
        {
        }
    }
}