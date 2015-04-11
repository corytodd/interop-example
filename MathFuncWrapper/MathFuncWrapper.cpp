// This is the main DLL file.

#pragma once

#include "stdafx.h"

// Include the header to our native library. Not that you
// MUST add BOTH the reference to the MathFuncDll project AND
// add the path $(SolutionDir)MathFuncDl to the Additional Include Directories 
// property for this project. That property is found under 
// Properties -> Configuration Properties -> C/C++ -> General
#include "MathFuncDll.h"

namespace MathFuncWrapper
{
	///
	/// Implements the wrapper functionality. Exposes exported functions
	/// in MathFuncDll as wrapped functions that are consumable from C#.
	/// Since these are all simple primitives we do not need to convert any values.
	/// If we were using String types, there would be some CLR legwork to get the 
	/// string properly marshalled between the native and C# code.
	///
	public ref class WrappedMathFunc
	{
	
	public:
		double AddWrapper(double a, double b) {
			return MathFuncs::MyMathFuncs::Add(a, b);
		}
		double SubtractWrapper(double a, double b) {
			return MathFuncs::MyMathFuncs::Subtract(a, b);
		}

		double MultiplyWrapper(double a, double b) {
			return MathFuncs::MyMathFuncs::Multiply(a, b);
		}


		// Note that this native code will throw an exception if b == 0
		// and I'm not entirely sure why we don't see that exception here.
		double DivideWrapper(double a, double b) {
			return MathFuncs::MyMathFuncs::Divide(a, b);
		}
	};

}

