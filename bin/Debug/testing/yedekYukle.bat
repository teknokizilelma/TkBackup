adb restore %UserProfile%\Documents\AndroidBackup\backup.ab
adb push %UserProfile%\Documents\AndroidBackup\mmssms.db /data/data/com.android.providers.telephony/databases/
adb push %UserProfile%\Documents\AndroidBackup\mmssms.db /data/data/com.sonyericsson.conversations/databases/
adb push %UserProfile%\Documents\AndroidBackup\mmssms.db /data/data/com.google.android.apps.messaging/databases/
adb push %UserProfile%\Documents\AndroidBackup\mmssms.db /data/data/com.jb.gosms/databases/
adb push %UserProfile%\Documents\AndroidBackup\mmssms.db /data/data/com.com.concentriclivers.mms.com.android.mms/databases/
adb push %UserProfile%\Documents\AndroidBackup\mmssms.db /data/data/fr.slvn.mms/databases/
adb push %UserProfile%\Documents\AndroidBackup\mmssms.db /data/data/com.android.mms/databases/
adb push %UserProfile%\Documents\AndroidBackup\mmssms.db /data/data/com.google.android.apps.messaging/databases/
adb push %UserProfile%\Documents\AndroidBackup\contacts2.db /data/data/com.android.contacts/databases/
adb push %UserProfile%\Documents\AndroidBackup\contacts2.db /data/data/com.Samsung.Android.contacts/databases/
adb push %UserProfile%\Documents\AndroidBackup\contacts2.db /data/data/com.android.providers.contacts/databases/
adb push %UserProfile%\Documents\AndroidBackup\contacts.db /data/data/com.Android.providers.contacts/databases/
adb push %UserProfile%\Documents\AndroidBackup\sdcard\ "/sdcard"
adb push %UserProfile%\Documents\AndroidBackup\sdcard\ "/storage/emulated/0"
adb push %UserProfile%\Documents\AndroidBackup\sdcard\ /sdcard/
adb push %UserProfile%\Documents\AndroidBackup\sdcard\ /storage/emulated/0/