Mohit

2022-11-04

0204
	-startig project with a slow internet and high caffine.
0225
	-needed more caffine
0240
	-commented code for siginig in statup.cs file
0245
	-time to debug
0249
	-The program '[24908] iisexpress.exe' has exited with code 4294967295 (0xffffffff). program crashed
0252
	-continued the process now, forgot to pulgin and click continue.
0255
	-confused to select the bootstrap theme, like the dark one
0300
	-added bootswatch theme, changed bootstrap classes in nav and loginpartials
0303
	- worked fine bootswatch theme applied
0307
	-pasted css and js links inlayout file
0316
	-COOOOOOOFFFFFFEEEEEEEEEE
0320
	-dropdown not working
0323
	-got dropdown from bootswatch instead of getbotstrap, but now its not collapsing
0338
	-couldn't figure out why dropdown is not working, moving to next part for now
0342
	-Added three new projects to solution, now time to install packages most error prone part
0347
	-As expected here is our beautiful error  (NU1202: Package Microsoft.EntityFrameworkCore.Relational 6.0.10 is not compatible with netcoreapp3.1 (.NETCoreApp,Version=v3.1)
	-Installing different version
0349
	-installed packages with version compaitable with .net3.1
0354
	-Edited namespace of db context and deleted class1 files, time to build
0355
	-error is welcoming us (The type or namespace name 'Data' does not exist in the namespace 'MohitsBookStore' (are you missing an assembly reference?)
0413
	-stuck on namespcase error, trying to continue with refrences
0416
	-error gone after adding references
0418
	-got a new error for errorviewmodel
0420
	-solved this by adding viewmodels in using statement
0422
	-got the same error twice after building
0424
	-got it same type of solution but in different file
0425
	-Finally build success, but dropdown still not working
0427
	-changed name of Models folder
0436
	got same error again in same file don't know why
0438
	-got an error while adding new ares, maybe i should fix prev errr first
0440
	-fixed err and build succeeded
0502
	-got error after running, couldn't figure it out so reverted back to working commit
0506
	-build , working , opened in browser, but still dropdown not working
1219
	-just noticed that addtional three projects are not in git repo folder creating a new repo to include it in


2022-11-07

0315
	-Because additional projects were not included in my github repo before, I created a new repo on github and added this readme and starting the new projct from starting
0332
	-Commented signin flag in startup.cs file
0347
	-checked debugging by adding breakpoint on privacy view
0409
	-Added bootswatch theme (Darkly), changed nav theme classes to match with bootswatch theme
0414
	-removed text-dark classes from login and register links
0424
	-Added additional css and javascript links in layout file
0430
	-Added dropdown from bootswatch theme
0448
	-Added three class library projects in the solution
0453
	-it class time , rest work for later

2022-11-08

1221
	-moved data folder to dataAccess project 
1222
	-installed to package dependencies in DataAccess
	-deleted migration folder
1234
	-installed EFcore
1236
	-edited namespace of dataAccess
1238
	-deleted class1 files
1242
	-Luckily Build completed with 4 succeeded and 0 failed
1250
	-Copied Model folder to outer project
1255
	-renamed models folder to ViewModels
	-Added project references
1259
	-Build completed with 1 succeeded 1 failed, finally got an error 
0104
	-editied homecontrolles to add viewModels and built now got 2 other errors
0105
	-It was same error as the last time, i hope it doesn't go on loo like last time.
0110
	- for now it built with 1 succeeded 0 failed,
0156
	- Created SD.cs class in utility project, can't understand what properties to change in this file
0200
	- Added project references
0203
	-got same error in that same file Error.cshtml.g.cs for the 7th time and it gets on repeated


0441
	-edited error viewmodel path to solve the last error that i got more that 8 times

2022-11-12

0144
	-Reviewing the project and next task
0207
	-Added Customers area and edited startup.cs to add appmvc area routes.
0222
	-Moved HomeController.cs to new customers area and added area refeerence
0223
	-woho now showing nothing on browser. let's find out in next steps
0237
	-Moved views and viewstart, viewimport file to new customer area rebuild succeeded.
	-But still showing blank page on browser.
0310
	-INdex page showing in browser when i add /Customers in url but not on base route
0331
	-Copied back viewstart and viewimport file because lastime i moved them instead of copying,
0342
	-Still couldn't figure out why route are not working correctly
	-Now trying to add admin area
0347
	-Added Admin area and copied same view files as last Area, not showing errors , actually not showing anything
0349
	-I doubt the last slide when it says delete controllers folder, but deleting it anyway because its clearly written their 
0510
	-Added route attribute to home controller in customer area to access index page from base url in the browser
	-this is the solution of that blank page in browser

0512
	-Heading for part-2