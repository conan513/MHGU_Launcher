@echo off
cd ..
set maindir=%CD%

:check_ryujinx
if exist "%maindir%\ryujinx\ryujinx.exe" goto ryujinx_pass
cls
echo Please copy the latest Ryujinx emulator into the "ryujinx" folder.
echo We recommend to use the Ryujinx with LDN support for working multiplayer.
echo.
pause
exit

:ryujinx_pass
if exist "%maindir%\game\mhgu_game.nsp" goto game_pass
cls
echo Please copy the game into the "game" folder.
echo Rename the game file to "mhgu_game.nsp"
echo.
pause
exit

:game_pass
cd "%maindir%\ryujinx"
Start "" ryujinx.exe -r "%maindir%\data" "%maindir%\game\mhgu_game.nsp"