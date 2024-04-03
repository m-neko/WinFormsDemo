#include "pch.h"

#include "CLRLibrary.h"

namespace CLRLibrary {

	int DllCLRClass::addIntNum(int a, int b) {
		MessageBox(NULL, L"C++/CLI ‚Åì¬‚µ‚½DLL“à‚ÅWindows API‚ÌMessageBox()‚ğŒÄ‚Ño‚µ‚Ü‚µ‚½", L"C++/CLI DLL “à‚Ìˆ—", MB_OK);
		return a + b;
	}

	void DllCLRClass::showMessage() {
		
	}

}

