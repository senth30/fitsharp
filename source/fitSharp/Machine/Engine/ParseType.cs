﻿// Copyright © 2009 Syterra Software Inc. All rights reserved.
// The use and distribution terms for this software are covered by the Common Public License 1.0 (http://opensource.org/licenses/cpl.php)
// which can be found in the file license.txt at the root of this distribution. By using this software in any fashion, you are agreeing
// to be bound by the terms of this license. You must not remove this notice, or any other, from this software.

using System;
using fitSharp.Machine.Model;

namespace fitSharp.Machine.Engine {
    public class ParseType<T>: ParseOperator<T> {
        public bool TryParse(Processor<T> processor, Type type, TypedValue instance, Tree<T> parameters, ref TypedValue result) {
            if (type != typeof (RuntimeType)) return false;
            result = new TypedValue(processor.ApplicationUnderTest.FindType(new IdentifierName(parameters.Value.ToString())), type);
            return true;
        }
    }
}