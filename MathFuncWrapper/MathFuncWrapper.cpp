// This is the main DLL file.

#pragma once

#include "stdafx.h"

#include "MathFuncDll.h"

namespace MathFuncWrapper
{
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

		double DivideWrapper(double a, double b) {
			return MathFuncs::MyMathFuncs::Divide(a, b);
		}
	};

}

