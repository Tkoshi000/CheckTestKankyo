; example1.nsi
;
; This script is perhaps one of the simplest NSIs you can make. All of the
; optional settings are left to their default settings. The installer simply 
; prompts the user asking them where to install, and drops a copy of example1.nsi
; there. 

;--------------------------------
!define APP "CheckTestKankyo"

!define VER "0.0.01"

!define ICON "v2.ico"

; The name of the installer
Name "Setup_${APP}${VER}"

; The file to write
OutFile "Setup_${APP}${VER}.exe"

; The default installation directory
;�C���X�g�[������v���O���������܂��B
InstallDir "$APPDATA\${APP}"

; Request application privileges for Windows Vista
RequestExecutionLevel user

;--------------------------------

; Pages
;�C���X�g�[������Ƃ��̃y�[�W�𑝂₷
Page directory
;--------------------------------
Page instfiles


; The stuff to install
Section "" ;No components page, name is not important

  ; Set output path to the installation directory.


  ;Save Point
  SetOutPath "$INSTDIR"
  ; SetOutPath  Put file there
  File /r /x "*.vshost.*" "${APP}\bin\Debug\*.*"

  ;CreateDirectory "$APPDATA\Unote"
;CreateShorCut "�V���[�g�J�b�g�̖��O�Əꏊ"�@"�����N����exe" "icon�t�@�C��"�@"icon�t�@�C���̔ԍ�"
; "�R�}���h���C��paramater"�@"�A�C�R���̐���"
  CreateShortCut "$DESKTOP\${APP}.lnk" "$INSTDIR\${APP}.exe" \
                 "" "$INSTDIR\${APP}.exe" 0 SW_SHOWNORMAL \
                 "" ""

;SW_SHOWMAXIMIZED
SectionEnd ; end the section
