## Building Rainmeter

### Get the source code

Use <a href="http://git-scm.com">Git</a> to clone the repository:

    git clone https://github.com/wcomhelp/rainmeter.git

Alternatively, download the repository contents as a [ZIP archive](https://github.com/rainmeter/rainmeter/archive/master.zip).


### Building with Visual Studio (Recommended)

#### Obtaining the tools

Rainmeter can be built using any version of Visual Studio 2017. If you don't already have VS2017, you can download [Visual Studio Community 2017](https://visualstudio.microsoft.com/vs/older-downloads/) for free.

Ensure you select the workload: "Desktop development with C++"

Ensure you select the individual components:

"VC++ 2017 version 15.9 v14.16 latest v141 tools"

"VC++ 2017 version 15.9 v14.16 Libs for Spectre (ARM)"

"Visual C++ 2017 Redistribute Update"

"Visual C++ compilers and libaries for ARM"

"Windows Universal CRT SDK"

"Windows 10 SDK (10.0.16299.0) for Desktop C++ [ARM and ARM64]"

"Windows Universal C Runtime"

#### Solving other issues with building

You will also need to copy the file from [here](https://gist.github.com/wcomhelp/a5701d4374d51066866e276c9e55f37b/raw/ea3428c3807d6c64ef4e11a2c329512eafcebc93/Microsoft.Visualstudio.TestTools.CppUnitTestFramework.arm.dll) to "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\CommonExtensions\Microsoft\TestWindow\Extensions\Cpp"

If your build for ARM still fails, copy the files from [here](https://github.com/MakiseKurisu/WindowsRTLib/tree/master/Lib) to "C:\Program Files (x86)\Windows Kits\10\Lib\10.0.16299.0\um\arm"

### Building the installer [NOT TESTED]

First, download and install [NSIS 3](http://nsis.sourceforge.net) or later.

Now you can simply run the <b>Build.bat</b> batch file in the Build folder of your local repository. If you see any "not found" errors, check that the paths in the `set` commands at the top of the file match your environment. To build the release (non-beta) installer, use `Build.bat RELEASE`.

To digitally sign the installer and the Rainmeter executables, obtain a Windows code signing certificate and create a Certificate.bat file alongside Build.bat with the following contents:

    set CERTFILE=/path/to/PFXcert.p12
    set CERTKEY=certpassword

