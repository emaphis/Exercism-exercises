module BookingUpForBeauty

// The following line is needed to use the DateTime type
open System


let schedule (appointmentDateDescription: string): DateTime =
    DateTime.Parse appointmentDateDescription


let hasPassed (appointmentDate: DateTime): bool =
    DateTime.Now > appointmentDate


/// Checks appointment is between Noon to 6.
let isAfternoonAppointment (appointmentDate: DateTime): bool =
    appointmentDate.Hour >= 12 && appointmentDate.Hour < 18


/// takes an appointment date and returns a description of that date and time:
/// "You have an appointment on 3/29/2019 3:00:00 PM."
let description (appointmentDate: DateTime): string =
    sprintf "You have an appointment on %O." appointmentDate


/// returns this year's anniversary date, which is September 15th
let anniversaryDate(): DateTime = DateTime(DateTime.Now.Year, 9, 15)