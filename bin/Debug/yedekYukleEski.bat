adb restore %UserProfile%\Documents\AndroidBackup\backup.ab
adb push %UserProfile%\Documents\AndroidBackup\sdcard\WhatsApp /storage/emulated/0/WhatsApp
adb push %UserProfile%\Documents\AndroidBackup\sdcard\WhatsApp /sdcard/WhatsApp

pause