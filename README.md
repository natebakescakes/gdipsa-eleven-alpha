# Eleven Alpha Sports Facility

GDipSA (Team 11A) Eleven Alpha

Our solution aims to provide Sports Centre Staff at Eleven Alpha Sports Facility intuitive control over their bookings. It is written in C# using Visual Studio 2017.

## Installation

1. Restore the `.bak` file into a default local instance of Microsoft SQL Server.
2. Open the solution in Visual Studio 2017 and **Build** the `ElevenAlpha.sln` solution file.

## Features

### High-level Bookings View

![Booking Visualisation](https://thumbs.gfycat.com/DetailedOccasionalAiredale-size_restricted.gif)

Provides a high-level view of bookings for the Facility Type and Date Range selected. Clicking on a time slot will open the booking details screen.

### Bookings Drill-down

Once in the booking details, users can book the specific room of that Facility Type. Even if the user has selected the wrong dates, the filter controls can be used to fine-tune the exact dates and Facility Types they wish to see in detail.

Once the member has confirmed, the staff member can input their Member ID to process the booking on their behalf.

### Members Tab

Users can view a list of all members using the Members Tab. Using this tab, users can perform various operations to manage the members of the Sports Hub.

### Facilities Tab

Facilities Tab allows users to view a list of all facilities in the Sports Hub. The management is done mainly using a Facility Type categorisation.

### Reports

Allows management to visualise the trends in booking so that they may make decisions on opening or closing Facilities, extending or reducing the opening hours as they see fit.

## Future Updates (and Known Issues)

1. Currently, opening hours are hard coded as 08:00 - 20:00 for all facilities. Our future release would allow users to customise the opening hours for each Facility.

2. When selecting a booking from the Booking Tab GridView, the subsequently opened Booking Details window does not pre-select the slot that was initially selected. This would be resolved in a future update.

3. Our management reports are currently limited by not allowing users to view Occupancy Rates and Booking Trends with a customised range of dates. We would like to implement such functionality in the future along with new reports.

4. Occupancy Rates report will show Error Dialogs but can be bypassed. We intend to fix this in the near future.

5. When deactivating member/facility, booking records still remain as 'Booked'. We intend to show it as a different status so that Staff Members will be aware of such situations.
