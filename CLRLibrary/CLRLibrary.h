#pragma once

#include <windows.h>

using namespace System;

namespace CLRLibrary {
	public ref class DllCLRClass
	{
	public:
		int addIntNum(int a, int b);
		void showMessage();
	};
}
