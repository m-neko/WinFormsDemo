#include "pch.h"

#include "CLRLibrary.h"

namespace CLRLibrary {

	int DllCLRClass::addIntNum(int a, int b) {
		MessageBox(NULL, L"C++/CLI �ō쐬����DLL����Windows API��MessageBox()���Ăяo���܂���", L"C++/CLI DLL ���̏���", MB_OK);
		return a + b;
	}

	void DllCLRClass::showMessage() {
		
	}

}

