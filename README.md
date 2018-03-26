Sports Facility Booking System
========================
GDipSA (Team 11A) Eleven Alpha

The software solution is for sports staff to make the booking/cancellation of facility in a sports center.This project is written using C# on visual studio 2017.

Function
==================
# Bookings 
* Select Facility Type and Date Period, View the vacancy for each facililty type.
* Click any time slot to see details in Booking Manager Form.
## Booking Manager Form
* All facility availability information of one type in the same day(can re-choose date and facility Type).
* Input memberID and make booking.
   
# Members 
* In member Tab, system shows all member List.
* Screen can hide inactive Member by checking "Hide Inactive Members" checkbox.
* In this Tab, there are New,Edit,Deactivate,Activate,View Booking history and View Member Report buttons.

New Button
* Click New button, New Member form shows.

## New button-New Member Form
* Input Member Information, click Add Member and close,back to Members Manager and member list is refreshed.
* Cannot add existing member.

## Edit Button-Edit Member Form
* Select any member,click Edit button, Edit Member form shows and pops out that members information.
* Change the information and click Update button and close,back to Members Manager and member list is refreshed.

## Deactive Button
* select any member,click Deactivate,the member which is selected is set to "discontinued" and member list is refreshed.

## Active Button
* Select any member,click Activate,the member which is selected is set to "Active" and member list is refreshed.

## View booking history Button —— Booking History(By Members) Form
* Click View Booking History button,Booking History(By Members) form shows.
* Select date period,input member ID,the booking history shows in screen.
* Search box can provide search by BookingID,Member Name and FacilityID.
* Select one Booking Transaction,click View Receipt button to View Booking Receipt.
* Select one Booking Transaction ,click Cancel Booking button to cancel booking(only when booking date is later than present date).
    
## View Member Report Button
* Click View Member Report to view all member List which contains Member ID,First Name,Last Name,Date Of Birth,Mobile Number and Email Address.

# Facility
* In Facility Tab, system shows list of all facilities.
* Screen can hide inactive Facility by clicking "Hide Inactive Facilities".
* In this Tab, there are New,Edit,Deactivate,Activate and View Booking history buttons.
New Button
* Click New button, New Facility Form shows.
## New button-New Facility Form
* Input Facility Name, Chose Facility Type,input location and description.
* Click Update, new facility is created (Facility Name cannot be an existing name in the database)
* If we need to create a new facility type, choose "Manage Facility Type..." in Facility Type Box. Then Facility Type Manager Form shows.
### Manage Facility Type... —— Facility Type Manager Form
* In Facility Type Manager Form,  there are buttons to Add/Delete/Update Facility Type.
* Facility Type that has booking records cannot be deleted. It can only be deactivated.
* Click close button, go back to New facility Form, Facility Type Box is refreshed.


## Edit Button —— Edit Facility Form
* Chose a facility and click edit, Edit facility Form shows.
* In Edit Facility Form, the selected member's details can be edited.
* Click Update Button, Facility information is changed and saved(Facility Name can't be found the same in the facility list).

## Deactive Button
* Select a facility,click Deactive button, choosen facility is deactive.

## Active Button
* Select a facility,click Active button, choosen facility is active.

## View booking history Button —— Booking History(By Facility) Form
* Click View Booking History button,Booking History(By Facility)  form shows.
* Select date period,input facility ID,the booking history shows in screen.
* Search box can provide search by BookingID,Member Name and FacilityID.
* Select one Booking Transaction,click View Receipt button to View Booking Receipt.
* Select one Booking Transaction ,click Cancel Booking button to cancel booking(only when booking date is later than system date).

# Reports
## View Occupancy Rates(All-time) button
* Click View Occupancy Rates(All-time) button to generate a report that shows the booking record for each time slot in each facility before generate reports time.

## View Booking Trends(Charts) button
* Click View Booking Trends(Charts) button to generate a report that shows the booking records trend by day/week/month.


