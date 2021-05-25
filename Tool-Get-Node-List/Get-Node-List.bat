@echo off 
:loop
node get_node.js
timeout /t 3600
goto loop