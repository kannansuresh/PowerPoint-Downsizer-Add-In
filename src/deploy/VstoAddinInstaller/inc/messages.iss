; =====================================================================
; == inc\messages.iss
; == Part of VstoAddinInstaller
; == (https://github.com/bovender/VstoAddinInstaller)
; == (c) 2016-2018 Daniel Kraus <bovender@bovender.de>
; == Published under the Apache License 2.0
; == See http://www.apache.org/licenses
; =====================================================================

en.OfficeIsRunning=Your Office application must be closed in order to continue installation. If you click 'OK', the application will be shut down.

en.SingleOrMulti=Single-user or system-wide install
en.SingleOrMultiSubcaption=Install for the current user only or for all users
en.SingleOrMultiDesc=Please indicate the scope of this installation:
en.SingleOrMultiSingle=Single user (only for me)
en.SingleOrMultiAll=All users (system-wide)
en.Office2007Required=This add-in requires Office 2007 or later. Setup will now terminate.

; CannotInstallPage [EN]
en.CannotInstallCaption=Administrator privileges required
en.CannotInstallDesc=You do not have the necessary rights to install additional required runtime files.
en.CannotInstallMsg=Additional runtime files from Microsoft are required to run this add-in. You may continue the installation, but the add-in won't start unless the required runtime files are installed by an administrator. Note: On Windows Vista and newer, right-click the installer file and choose 'Run as administrator'.
en.CannotInstallCont=Continue anyway, although it won't work without the required runtime files
en.CannotInstallAbort=Abort the installation (come back when the admin has installed the files)

; DownloadInfoPage [EN]
en.RequiredCaption=Additional runtime files required
en.RequiredDesc=Additional runtime files for the .NET framework from Microsoft are required in order to run this add-in.
en.RequiredMsg=%d file(s) totalling about %s MiB need to be downloaded from the Microsoft servers. Click 'Next' to start downloading.

; InstallInfoPage [EN]
en.InstallCaption=Runtime files downloaded
en.InstallDesc=The required runtime files are ready to install.
en.InstallMsg=Click 'Next' to begin the installation.

en.StillNotInstalled=The required additional runtime files are still not installed. Setup will continue, but unless you ensure that the runtime are properly installed, the add-in will not function properly.
en.DownloadNotValidated=A downloaded file has unexpected content. It may have not been downloaded correctly, or someone might have hampered with it. You may click 'Back' and then 'Next' to download it again.
