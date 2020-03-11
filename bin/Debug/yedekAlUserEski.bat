adb backup -apk -obb -shared -all -nosystem -f %UserProfile%\Documents\AndroidBackup\backup.ab
adb pull "/sdcard/WhatsApp" %UserProfile%\Documents\AndroidBackup\sdcard\WhatsApp
adb pull "/storage/emulated/0/WhatsApp" %UserProfile%\Documents\AndroidBackup\sdcard\WhatsApp
pause