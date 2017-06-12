from time import sleep
import datetime as dt

while(True):
    curTime = dt.datetime.now()
    curSecond = "{0:b}.format(curTime.second)
    curMinute = "{0:b}.format(curTime.minute)
    curHour = "{0:b}".format(curTime.hour)
    
    print ("{} - {} - {}".format(curHour, curMinute, curSecond))
    sleep(1)
