// dllmain.cpp : DLL アプリケーションのエントリ ポイントを定義します。
#include "pch.h"

#define EXPORT extern "C" __declspec(dllexport)

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

EXPORT int addIntNum(int a, int b) {
    MessageBox(NULL,L"C++ で作成したネイティブDLL内でWindows APIのMessageBox()を呼び出しました",L"C++ ネイティブDLL内の処理",MB_OK);
    return a + b;
}

