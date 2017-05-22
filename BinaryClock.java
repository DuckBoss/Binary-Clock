import java.time.LocalTime;

public class BinaryClock {
	public static void main(String[] args) throws InterruptedException {
		while(true) {
			LocalTime time = LocalTime.now();
			int curSec = time.getSecond();
			int curMin = time.getMinute();
			int curHour = time.getMinute();
			
			String timeFormat = String.format("%s - %s - %s", Integer.toBinaryString(curHour), Integer.toBinaryString(curMin), Integer.toBinaryString(curSec));
			System.out.println(timeFormat);
			Thread.sleep(1000);
		}
	}
}
