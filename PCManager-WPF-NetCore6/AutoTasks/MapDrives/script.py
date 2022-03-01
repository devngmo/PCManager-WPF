SHARED_USB_LABEL = 'WUSB'
def onTriggered(trigger, args):
	if trigger == 'drive.plugged.in':
		type = args[0]
		if type == 'USB':
			letter = args[1]
			label = SYSAPI.getDriveLabel(letter)
			if label == SHARED_USB_LABEL:
				# map my USB as Drive P: Portable on all device ( office, home )
				SYSAPI.mapDrive(letter, 'P')

	if trigger == 'drive.removed':
		if not SYSAPI.canAccessDrive('P'):
			SYSAPI.removeMapDrive('P')

	if trigger == 'system.startup':
		letter = SYSAPI.getDriveLetterByLabel(SHARED_USB_LABEL)
		SYSAPI.mapDrive(letter, 'P')

		# map on work PC
		if os.path.exists('D:\\calibre_book_library'):
			SYSAPI.mapFolderToDrive('D:\\calibre_book_library', 'X')

		# map on home PC
		if os.path.exists('E:\\calibre_book_library'):
			SYSAPI.mapFolderToDrive('E:\\calibre_book_library', 'X')