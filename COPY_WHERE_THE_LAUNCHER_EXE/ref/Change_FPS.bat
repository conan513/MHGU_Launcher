@echo off
cd ..
set maindir=%CD%

:check_ce
if exist "%maindir%\Cheat Engine.exe" goto ce_install_pass
echo Please copy or install the Cheat Engine files into "ce" folder.
echo.
pause
exit

:ce_install_pass
tasklist /FI "IMAGENAME eq Ryujinx.exe" 2>NUL | find /I /N "Ryujinx.exe">NUL
if "%ERRORLEVEL%"=="0" goto pass
if "%ERRORLEVEL%"=="1" goto no_ryu

:no_ryu
cls
echo Oops!!! Looks like the game is not running.
echo Please start the game first.
echo.
pause
exit

:pass
cd ce
"%CD%\Cheat Engine.exe" "%maindir%\ref\MHGU_FPS_Limit.CT"