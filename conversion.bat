@echo off
set currentDir="%cd%"
set fileName=C:\Users\Nolan\source\repos\UnitConverter\UnitConverter\bin\Debug\UnitConverter.exe
set argCount=0

REM For loop to see how many arguments there are
for %%x in (%*) do Set /A argCount+=1

REM Ensuring we have enough params to continue
IF %argCount% GEQ 2 (
    %fileName% %1 %2
) ELSE (
REM We have no args
    echo Error: Please enter a location to count
)