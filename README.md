Sports Facility Booking System
========================
GDipSA (Team 11A) Eleven Alpha

The software solution is for sports staff to make the booking/cancellation of facilittie in a sports center.This project is written uising C# on visual studio 2017.

Function
==================
# Bookings 
* Select Facility Type and Date Period, View the avalible time slot .
* click any time slot to see details in Booking Manager Form.
## Booking Manager Form
* All facility avalilibity information of one type in the same day(can re-choose date and facility Type).
* input memberID and make mooking.
   
# Members 
* In member Tab, system shows all member List.
* Screen can hide inactive Member by click "Hide Inactive Members".
* In this Tab, there are New,Edit,Deactive,Active,View Booking hitory,View Member Report total 6 button.
New Button
* click New button, New Member form shows.

## New button-New Member Form
* Input Member Information, click Add Member and close,back to Members Manager and member list refresh.
* Can't add exist member.

## Edit Button-Edit Member Form
* select any member,click Edit button, Edit Member form shows and pops out the member information which is selected.
* chaneg the information and click Update button and close,back to Members Manager and member list refresh.

## Deactive Button
* select any member,click Deactive,the member which is selected is set deactive and member list refresh.

## Active Button
* select any member,click Active,the member which is selected is set Active and member list refresh.

## View booking history Button —— Booking History(By Members) Form
* Click View Booking History button,Booking History(By Members) form shows.
* Select date period,input member ID,the booking history shows in screen.
* Search box can provide search by BookingID,Member Name and FacilityID.
* select one Booking Transaction,click View Receipt button to View Booking Receipt.
* select one Booking Transaction ,click Cancel Booking button to cancel booking(only when booking date is later than system date).
    
## View Member Report Button
* Click View Member Report to view all Member List whick Contains MemberID,FirstName,LasteName,DateOfBirth,Mobile,EmailAdress.

# Facility
* In Facility Tab, system shows all facility List.
* Screen can hide inactive Facility by click "Hide Inactive Facilities".
* In this Tab, there are New,Edit,Deactive,Active,View Booking hitory total 6 button.
New Button
* click New button, New Facility shows.
## New button-New Facility Form
* Input Facility Name, Chose Facility Type,input location and description.
* Click Update, new facility is created (Facility Name can't be found the same in the facilty list)
* if need create new facility type, choose "Manage Facility Type..." in Facility Type Box,Facility Type Manager Form shows.
### Manage Facility Type... —— Facility Type Manager Form
* In Facility Type Manager Form, Can do Add/Delete/Update Facility Type.
* Can't delete Facility Type that has booking records.
* Click close button, go back to New facility Form, Facility Type Box refreshed.


## Edit Button —— Edit Facility Form
* Chose a facilty and click edit, Edit facility Form shows.
* In Edit Facility Form, the information deafault is what already choosed but also can be edit.
* Click Update Button, Facility information is changed and saved(Facility Name can't be found the same in the facilty list).

## Deactive Button
* select a facility,click Deactive button, choosen facility is deactive.

## Active Button
* select a facility,click Active button, choosen facility is active.

## View booking history Button —— Booking History(By Facility) Form
* Click View Booking History button,Booking History(By Facility)  form shows.
* Select date period,input facility ID,the booking history shows in screen.
* Search box can provide search by BookingID,Member Name and FacilityID.
* select one Booking Transaction,click View Receipt button to View Booking Receipt.
* select one Booking Transaction ,click Cancel Booking button to cancel booking(only when booking date is later than system date).

# Reports
## View Occupancy Rates(All-time) button
* Click View Occupancy Rates(All-time) button to generate a report that shows the booking record for each time slot in each facility before generate reports time.

## View Booking Trends(Charts) button
* Click View Booking Trends(Charts) button to generate a report that shows the booking records trend by day/week/month.


