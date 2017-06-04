import java.time.LocalTime

fun main(args: Array<String>) {
    while (true) {
        val time: LocalTime = LocalTime.now()
        val curSec = time.second
        val curMin = time.minute
        val curHour = time.hour

        val timeFormat: String? = "%s - %s - %s".format(Integer.toBinaryString(curHour), Integer.toBinaryString(curMin), Integer.toBinaryString(curSec))
        println(timeFormat)
        Thread.sleep(1000)
    }
}
