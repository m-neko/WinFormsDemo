#include "pch.h"

#include "CLRLibrary.h"

namespace CLRLibrary {

	int DllCLRClass::addIntNum(int a, int b) {
		MessageBox(NULL, L"C++/CLI で作成したDLL内でWindows APIのMessageBox()を呼び出しました", L"C++/CLI DLL 内の処理", MB_OK);
		return a + b;
	}

	void DllCLRClass::showMessage() {
		
	}

}

