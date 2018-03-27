# Function List

## Bookings Tab

* Select Facility Type and Date Period, View the vacancy for each facililty type.
* Click any time slot to see details in Booking Manager Form.

## Booking Manager Form

* All facility availability information of one type in the same day(can re-choose date and facility Type).
* Input memberID and make booking.

## Members Tab

* In member Tab, system shows all member List.
* Screen can hide inactive Member by checking "Hide Inactive Members" checkbox.
* In this Tab, there are New,Edit,Deactivate,Activate,View Booking history and View Member Report buttons.

### New Button

* Clicking the new button brings the user to the New Member form.

### Edit Button

* Clicking the new button brings the user to the Edit Member form.

### Deactivate Button

* select any member,click Deactivate,the member which is selected is set to "discontinued" and member list is refreshed.

### Active Button

* Select any member,click Activate,the member which is selected is set to "Active" and member list is refreshed.

### View Booking History Button

* Clicking the View Booking History button will bring the user to the Booking History (By Members) form.

## View Member Report Button

* Click View Member Report to view all member List which contains Member ID,First Name,Last Name,Date Of Birth,Mobile Number and Email Address.

## Members Form

### New Member Form

* Input Member Information, click Add Member and close,back to Members Manager and member list is refreshed.
* Cannot add existing member.

### Edit Member Form

* Select any member,click Edit button, Edit Member form shows and pops out that members information.
* Change the information and click Update button and close,back to Members Manager and member list is refreshed.

## Booking History (By Members) Form

* Click View Booking History button,Booking History(By Members) form shows.
* Select date period,input member ID,the booking history shows in screen.
* Search box can provide search by BookingID,Member Name and FacilityID.
* Select one Booking Transaction,click View Receipt button to View Booking Receipt.
* Select one Booking Transaction ,click Cancel Booking button to cancel booking(only when booking date is later than present date).

## Facilities Tab

* In Facility Tab, system shows list of all facilities.
* Screen can hide inactive Facility by clicking "Hide Inactive Facilities".
* In this Tab, there are New,Edit,Deactivate,Activate and View Booking history buttons.

### New Button

* Click New button, New Facility Form shows.

### New Facility Form

* Input Facility Name, Chose Facility Type,input location and description.
* Click Update, new facility is created (Facility Name cannot be an existing name in the database)
* If we need to create a new facility type, choose "Manage Facility Type..." in Facility Type Box. Then Facility Type Manager Form shows.

### Facility Type Manager Form

* In Facility Type Manager Form,  there are buttons to Add/Delete/Update Facility Type.
* Facility Type that has booking records cannot be deleted. It can only be deactivated.
* Click close button, go back to New facility Form, Facility Type Box is refreshed.

### Edit Button —— Edit Facility Form

* Chose a facility and click edit, Edit facility Form shows.
* In Edit Facility Form, the selected member's details can be edited.
* Click Update Button, Facility information is changed and saved(Facility Name can't be found the same in the facility list).

### Deactivate Button

* Select a facility,click Deactivate button, chosen facility is deactivated.

### Active Button

* Select a facility,click Active button, chosen facility is activated.

### View booking history Button —— Booking History(By Facility) Form

* Click View Booking History button,Booking History(By Facility)  form shows.
* Select date period,input facility ID,the booking history shows in screen.
* Search box can provide search by BookingID,Member Name and FacilityID.
* Select one Booking Transaction,click View Receipt button to View Booking Receipt.
* Select one Booking Transaction ,click Cancel Booking button to cancel booking(only when booking date is later than system date).

## Reports

### View Occupancy Rates(All-time) button

* Click View Occupancy Rates(All-time) button to generate a report that shows the booking record for each time slot in each facility before generate reports time.

### View Booking Trends(Charts) button

* Click View Booking Trends(Charts) button to generate a report that shows the booking records trend by day/week/month.
