adb backup -apk -shared -all -f %UserProfile%\Documents\AndroidBackup\backup.ab
adb pull /data/data/com.android.providers.telephony/databases/mmssms.db %UserProfile%\Documents\AndroidBackup\mmssms.db
adb pull /data/data/com.sonyericsson.conversations/databases/mmssms.db %UserProfile%\Documents\AndroidBackup\mmssms.db
adb pull /data/data/com.google.android.apps.messaging/databases/mmssms.db %UserProfile%\Documents\AndroidBackup\mmssms.db
adb pull /data/data/com.jb.gosms/databases/mmssms.db %UserProfile%\Documents\AndroidBackup\mmssms.db
adb pull /data/data/com.com.concentriclivers.mms.com.android.mms/databases/mmssms.db %UserProfile%\Documents\AndroidBackup\mmssms.db
adb pull /data/data/fr.slvn.mms/databases/mmssms.db %UserProfile%\Documents\AndroidBackup\mmssms.db
adb pull /data/data/com.android.mms/databases/mmssms.db %UserProfile%\Documents\AndroidBackup\mmssms.db
adb pull /data/data/com.google.android.apps.messaging/databases/mmssms.db %UserProfile%\Documents\AndroidBackup\mmssms.db
adb pull /data/data/com.android.providers.contacts/databases/contacts2.db %UserProfile%\Documents\AndroidBackup\contacts2.db
adb pull /data/data/com.Android.providers.contacts/databases/contacts.db %UserProfile%\Documents\AndroidBackup\contacts2.db
adb pull /data/data/com.android.contacts/databases/contacts2.db %UserProfile%\Documents\AndroidBackup\contacts2.db
adb pull /data/data/com.Samsung.Android.contacts/databases/contacts2.db %UserProfile%\Documents\AndroidBackup\contacts2.db
adb pull "/sdcard" %UserProfile%\Documents\AndroidBackup\sdcard
adb pull "/storage/emulated/0" %UserProfile%\Documents\AndroidBackup\sdcard