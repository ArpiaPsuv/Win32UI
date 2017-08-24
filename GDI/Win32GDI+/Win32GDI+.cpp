// Win32GDI+.cpp : ����Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
#include "Win32GDI+.h"
#include "Dwmapi.h"//ë����

#include<gdiplus.h>
#include<iostream>
using namespace Gdiplus;
#pragma comment(lib, "GdiPlus.lib")
#pragma comment(lib, "Dwmapi.lib")
#pragma comment(linker, "/subsystem:\"console\" /entry:\"wWinMainCRTStartup\" ")


#define MAX_LOADSTRING 100

// ȫ�ֱ���: 
HINSTANCE hInst;                                // ��ǰʵ��
WCHAR szTitle[MAX_LOADSTRING];                  // �������ı�
WCHAR szWindowClass[MAX_LOADSTRING];            // ����������
HRESULT EnableBlurBehind(HWND hwnd);			// ë����
void EnableTransparent(HWND hWnd);
HRESULT ExtendIntoClientAll(HWND hWnd);

// �˴���ģ���а����ĺ�����ǰ������: 
ATOM                MyRegisterClass(HINSTANCE hInstance);
BOOL                InitInstance(HINSTANCE, int);
LRESULT CALLBACK    WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK    About(HWND, UINT, WPARAM, LPARAM);
void TestGdiplus(HWND hwnd, HDC hdc);

int APIENTRY wWinMain(_In_ HINSTANCE hInstance,
                     _In_opt_ HINSTANCE hPrevInstance,
                     _In_ LPWSTR    lpCmdLine,
                     _In_ int       nCmdShow)
{
    UNREFERENCED_PARAMETER(hPrevInstance);
    UNREFERENCED_PARAMETER(lpCmdLine);

    // TODO: �ڴ˷��ô��롣
	ULONG_PTR g_gdiplusToken;
	GdiplusStartupInput gdiStartupInput;
	GdiplusStartup(&g_gdiplusToken, &gdiStartupInput, NULL);

    // ��ʼ��ȫ���ַ���
    LoadStringW(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
    LoadStringW(hInstance, IDC_WIN32GDI, szWindowClass, MAX_LOADSTRING);
    MyRegisterClass(hInstance);

    // ִ��Ӧ�ó����ʼ��: 
    if (!InitInstance (hInstance, nCmdShow))
    {
        return FALSE;
    }

    HACCEL hAccelTable = LoadAccelerators(hInstance, MAKEINTRESOURCE(IDC_WIN32GDI));

    MSG msg;

    // ����Ϣѭ��: 
    while (GetMessage(&msg, nullptr, 0, 0))
    {
        if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg))
        {
            TranslateMessage(&msg);
            DispatchMessage(&msg);
        }
    }

	GdiplusShutdown(g_gdiplusToken);
    return (int) msg.wParam;
}



//
//  ����: MyRegisterClass()
//
//  Ŀ��: ע�ᴰ���ࡣ
//
ATOM MyRegisterClass(HINSTANCE hInstance)
{
    WNDCLASSEXW wcex;

    wcex.cbSize = sizeof(WNDCLASSEX);

    wcex.style          = CS_HREDRAW | CS_VREDRAW;
    wcex.lpfnWndProc    = WndProc;
    wcex.cbClsExtra     = 0;
    wcex.cbWndExtra     = 0;
    wcex.hInstance      = hInstance;
    wcex.hIcon          = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_WIN32GDI));
    wcex.hCursor        = LoadCursor(nullptr, IDC_ARROW);
    wcex.hbrBackground  = (HBRUSH)(COLOR_WINDOWFRAME + 1);//
    wcex.lpszMenuName   = MAKEINTRESOURCEW(IDC_WIN32GDI);
    wcex.lpszClassName  = szWindowClass;
    wcex.hIconSm        = LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_SMALL));

    return RegisterClassExW(&wcex);
}

//
//   ����: InitInstance(HINSTANCE, int)
//
//   Ŀ��: ����ʵ�����������������
//
//   ע��: 
//
//        �ڴ˺����У�������ȫ�ֱ����б���ʵ�������
//        ��������ʾ�����򴰿ڡ�
//
BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
   hInst = hInstance; // ��ʵ������洢��ȫ�ֱ�����

   HWND hWnd = CreateWindowW(szWindowClass, szTitle, WS_OVERLAPPEDWINDOW,
      CW_USEDEFAULT, 0, CW_USEDEFAULT, 0, nullptr, nullptr, hInstance, nullptr);

   if (!hWnd)
   {
      return FALSE;
   }

   //ExtendIntoClientAll(hWnd);
   EnableTransparent(hWnd);
   EnableBlurBehind(hWnd);
   ShowWindow(hWnd, nCmdShow);
   UpdateWindow(hWnd);
   //EnableBlurBehind(hWnd);//���ڴ˴��ᵼ��titleû��ë����

   return TRUE;
}

//
//  ����: WndProc(HWND, UINT, WPARAM, LPARAM)
//
//  Ŀ��:    ���������ڵ���Ϣ��
//
//  WM_COMMAND  - ����Ӧ�ó���˵�
//  WM_PAINT    - ����������
//  WM_DESTROY  - �����˳���Ϣ������
//
//
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	switch (message)
	{
	case WM_COMMAND:
	{
		int wmId = LOWORD(wParam);
		// �����˵�ѡ��: 
		switch (wmId)
		{
		case IDM_ABOUT:
			DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About);
			break;
		case IDM_EXIT:
			DestroyWindow(hWnd);
			break;
		default:
			return DefWindowProc(hWnd, message, wParam, lParam);
		}
	}
		break;
	case WM_ERASEBKGND:
	{
		int i = 5;
	}
		break;
	case WM_PAINT:
	{
		PAINTSTRUCT ps;
		HDC hdc = BeginPaint(hWnd, &ps);
		// TODO: �ڴ˴����ʹ�� hdc ���κλ�ͼ����...
		std::cout << ps.rcPaint.left << " : " << ps.rcPaint.top << " : " << ps.rcPaint.right << " : " << ps.rcPaint.bottom << std::endl;
		RECT rect;
		::GetUpdateRect(hWnd, &rect, true);
		TestGdiplus(hWnd, hdc);
		EndPaint(hWnd, &ps);
	}
		break;
	case WM_SIZE:
	{
		UINT width = LOWORD(lParam);
		UINT height = HIWORD(lParam);
		std::cout << "new width : " << width << "  new height : " << height << std::endl;
	}
		break;
    case WM_DESTROY:
        PostQuitMessage(0);
        break;
    default:
        return DefWindowProc(hWnd, message, wParam, lParam);
    }
    return 0;
}

// �����ڡ������Ϣ�������
INT_PTR CALLBACK About(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
    UNREFERENCED_PARAMETER(lParam);
    switch (message)
    {
    case WM_INITDIALOG:
        return (INT_PTR)TRUE;

    case WM_COMMAND:
        if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
        {
            EndDialog(hDlg, LOWORD(wParam));
            return (INT_PTR)TRUE;
        }
        break;
    }
    return (INT_PTR)FALSE;
}

void TestGdiplus(HWND hwnd, HDC hdc)
{
	Image image(L"test.png");
	if (image.GetLastStatus() != Status::Ok) {
		MessageBox(hwnd, L"����ͼƬʧ��", L"����", MB_OK);
		return;
	}
	auto width  = image.GetWidth();
	auto height = image.GetHeight();
	Graphics graphic(hdc);
	graphic.DrawImage(&image, 100, 100, width, height);

	LinearGradientBrush linGrBrush(
		Point(100, 0),
		Point(width+100, 0),
		Color(0x0, 0x0, 0x0, 0x0),  //���ɫ��	
		Color::Green			    //ֹ��ɫ��
	);  

	graphic.FillRectangle(&linGrBrush, 100, 100, width, height);
}

BOOL TryWin10(HWND hWnd)
{
	typedef enum _WINDOWCOMPOSITIONATTRIB
	{
		WCA_UNDEFINED = 0,
		WCA_NCRENDERING_ENABLED = 1,
		WCA_NCRENDERING_POLICY = 2,
		WCA_TRANSITIONS_FORCEDISABLED = 3,
		WCA_ALLOW_NCPAINT = 4,
		WCA_CAPTION_BUTTON_BOUNDS = 5,
		WCA_NONCLIENT_RTL_LAYOUT = 6,
		WCA_FORCE_ICONIC_REPRESENTATION = 7,
		WCA_EXTENDED_FRAME_BOUNDS = 8,
		WCA_HAS_ICONIC_BITMAP = 9,
		WCA_THEME_ATTRIBUTES = 10,
		WCA_NCRENDERING_EXILED = 11,
		WCA_NCADORNMENTINFO = 12,
		WCA_EXCLUDED_FROM_LIVEPREVIEW = 13,
		WCA_VIDEO_OVERLAY_ACTIVE = 14,
		WCA_FORCE_ACTIVEWINDOW_APPEARANCE = 15,
		WCA_DISALLOW_PEEK = 16,
		WCA_CLOAK = 17,
		WCA_CLOAKED = 18,
		WCA_ACCENT_POLICY = 19, /////19����
		WCA_FREEZE_REPRESENTATION = 20,
		WCA_EVER_UNCLOAKED = 21,
		WCA_VISUAL_OWNER = 22,
		WCA_LAST = 23
	} WINDOWCOMPOSITIONATTRIB;

	typedef struct _WINDOWCOMPOSITIONATTRIBDATA
	{
		WINDOWCOMPOSITIONATTRIB Attrib;
		PVOID					pvData;
		SIZE_T					cbData;
		
	} WINDOWCOMPOSITIONATTRIBDATA;

	typedef enum _ACCENT_STATE
	{
		ACCENT_DISABLED = 0,
		ACCENT_ENABLE_GRADIENT = 1,
		ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
		ACCENT_ENABLE_BLURBEHIND = 3,
		ACCENT_INVALID_STATE = 4
	} ACCENT_STATE;

	typedef struct _ACCENT_POLICY
	{
		ACCENT_STATE	AccentState;
		DWORD			AccentFlags;
		DWORD			GradientColor;
		DWORD			AnimationId;
	} ACCENT_POLICY;

	typedef BOOL(WINAPI*pfnSetWindowCompositionAttribute)(HWND, WINDOWCOMPOSITIONATTRIBDATA*);

	HMODULE hUser = GetModuleHandle(L"user32.dll");
	if (hUser)
	{
		pfnSetWindowCompositionAttribute setWindowCompositionAttribute = (pfnSetWindowCompositionAttribute)GetProcAddress(hUser, "SetWindowCompositionAttribute");
		if (setWindowCompositionAttribute)
		{
			ACCENT_POLICY				accentPolicy{ ACCENT_ENABLE_BLURBEHIND, 0, 0, 0 };//0x20 | 0x40 | 0x80 | 0x100
			WINDOWCOMPOSITIONATTRIBDATA data{ WCA_ACCENT_POLICY, &accentPolicy, sizeof(ACCENT_POLICY)};
			return setWindowCompositionAttribute(hWnd, &data);
		}
	}
	return false;
}

HRESULT ExtendIntoClientAll(HWND hwnd)
{
	// Negative margins have special meaning to DwmExtendFrameIntoClientArea.
	// Negative margins create the "sheet of glass" effect, where the client area
	// is rendered as a solid surface with no window border.
	MARGINS margins = { -1 };
	HRESULT hr = S_OK;

	// Extend the frame across the entire window.
	hr = DwmExtendFrameIntoClientArea(hwnd, &margins);
	if (SUCCEEDED(hr))
	{
		// ...
	}
	return hr;
}

void EnableTransparent(HWND  hwnd)
{
	//������͸��
	DWORD exStyle = ::GetWindowLong(hwnd, GWL_EXSTYLE);
	exStyle |= WS_EX_LAYERED;
	::SetWindowLong(hwnd, GWL_EXSTYLE, exStyle);
	//::SetLayeredWindowAttributes(hwnd, RGB(0, 0, 0), 200, LWA_COLORKEY);
	::SetLayeredWindowAttributes(hwnd, RGB(0, 0, 0), 230, LWA_ALPHA);
	//::UpdateLayeredWindow(hwnd, );																
}

HRESULT EnableBlurBehind(HWND hwnd)
{
	//����ë����
	if (TryWin10(hwnd))
		return S_OK;

	HRESULT hr = S_OK;

	// Create and populate the blur-behind structure.
	DWM_BLURBEHIND bb = { 0 };

	// Specify blur-behind and blur region.
	bb.dwFlags = DWM_BB_ENABLE;
	bb.fEnable = true;
	bb.hRgnBlur = NULL;

	// Enable blur-behind.
	hr = DwmEnableBlurBehindWindow(hwnd, &bb);
	if (SUCCEEDED(hr))
	{
		// ...
	}
	return hr;
}