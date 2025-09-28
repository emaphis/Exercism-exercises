/*
 * Exercise 2.
 *
 */

/**
 *
 * @author emaph
 */
public class MakeStrings {
    public static void main(String[] args) {
        var appointmentDateDescription = "07/25/2019 13:45:00";

        int month = Integer.parseInt(appointmentDateDescription.substring(0, 2));
        int day = Integer.parseInt(appointmentDateDescription.substring(3, 5));
        int year = Integer.parseInt(appointmentDateDescription.substring(6, 10 ));
        int hour = Integer.parseInt(appointmentDateDescription.substring(11, 13 ));
        int minutes = Integer.parseInt(appointmentDateDescription.substring(14, 16));
        int secondes = Integer.parseInt(appointmentDateDescription.substring(17, 19));

        System.out.println(month + "/" + day + "/" + year + " " + hour + ":" + minutes + ":" + secondes);
    }

}
