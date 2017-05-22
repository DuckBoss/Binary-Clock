from time import sleep
import datetime

while(True):
    curTime = datetime.datetime.now()
    curSecond = curTime.second
    curMinute = curTime.minute
    curHour = curTime.hour

    curSecondBin = "{0:b}".format(curSecond)
    curMinuteBin = "{0:b}".format(curMinute)
    curHourBin = "{0:b}".format(curHour)
    outputString = '{} - {} - {}'.format(curHourBin, curMinuteBin, curSecondBin)
    print (outputString)
    sleep(1)
