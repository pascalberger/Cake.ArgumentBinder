//
// Copyright Seth Hendrick 2019.
// Distributed under the MIT License.
// (See accompanying file LICENSE in the root of the repository).
//

// For intellisense in VS Code
#tool "nuget:?package=Cake.Bakery"

#load "./DeleteHelpers.cake"
#load "./FIGLet.cake"

const string defaultTarget = "default";

string target = Argument( "target", defaultTarget );

Task( defaultTarget )
.Does(
    () =>
    {
        Information( "Hello, World!" );
    }
).Description( "Default target, prints 'Hello, World!'" );

RunTarget( target );
