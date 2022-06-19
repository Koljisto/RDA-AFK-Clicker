#NoEnv
			
SetWorkingDir E:\SharpProjects\RDA-AFK-Clicker\RDA-AFK-Clicker\bin\Release\Scripts
			
CoordMode, Mouse, Screen
			
SendMode Input
			
#SingleInstance Force
			
SetTitleMatchMode 2
			
#WinActivateForce
			
SetControlDelay 1
			
SetWinDelay 0
			
SetKeyDelay -1
			
SetMouseDelay -1
			
SetBatchLines -1
			
CustomColor = FFFFFF  ; Can be any RGB color (it will be made transparent below).

			
Gui +LastFound +AlwaysOnTop -Caption +ToolWindow
			
Gui, Color, FFFFFF
			
Gui, Font, s32  ; Set a large font size (32-point).
			
Gui, Add, Text, vMyText cLime, Идёт выполнение...Ctrl+S для ОСТАНОВКИ
			
WinSet, TransColor, FFFFFF 150
			
Gui, Show, x100 y400 NoActivate
			
loop:=1
			
while(loop = 1)
			
{
