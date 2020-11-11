# My Plant Diary

---

Design Document  

Brandan Jones  

## Introduction 

Do you remember when you planted the apple tree?  Do you know when to water and fertilize your plants? MyPlantDiary can help you:  

-	Record dates and locations where you planted plants.
-	Take and view photos of a plant throughout its life.
-	Record when you added water, fertilizer, and other amendments.
-	Be aware of upcoming events for a plant: when to water, when growing season ends, etc.  

Use your web browser to create your own plant diary.  Create reminders based on what you did in previous years.   Receive alerts about upcoming events for your plant.  

## Data Feeds
[WeatherBit](https://api.weatherbit.io/v2.0/current?&city=Cincinnati&country=USA)

[PlantPlaces.com Specimen Locations](https://www.plantplaces.com/perl/mobile/viewspecimenlocations.pl)

[PlantPlaces.com Plant Name Lookup](https://www.plantplaces.com/perl/mobile/viewplantsjsonarray.pl)


## Functional Requirements

### Requirement 100.0: Search for Plants

#### Scenario

As a user interested in plants, I want to be able to search plants based on any part of the name: genus, species, cultivar, or common name.  

#### Dependencies

Plant search data are available and accessible.  

#### Assumptions

Scientific names are stated in Latin.  

Common names are stated in English.  
#### Examples
1.1  

**Given** a feed of plant data is available  

**When**  I search for “Redbud”  

**Then** I should receive at least one result with these attributes:  

Genus: Cercis  

Species: canadensis  

Common: Eastern Redbud  


1.2  
**Given** a feed of plant data is available  

**When** I search for “Quercus”  

**Then** I should receive at least one result with these attributes:   

Genus: Quercus  
Species: robur  
Common: English Oak  
And I should receive at least one result with these attributes:  
Genus: Quercus  
Species: alba  
Common: White Oak  

1.3  
**Given** a feed of plant data is available  
**When** I search for “sklujapouetllkjsda;u”  
**Then** I should receive zero results (an empty list)  



### Requirement 101: Save Specimen

#### Scenario

As a user interested in plants, I want to be able to enter and save details of a specimen: date planted, photos, and locations, so that I can view a history of this plant.  

#### Dependencies
Plant search data are available and accessible.  
The device has a camera, and the user has granted access to the camera.  
The device has GPS capabilities, and the user has granted location access.  

#### Assumptions  
Scientific names are stated in Latin.  
Common names are stated in English.  

#### Examples  

1.1  
**Given** a feed of plant data is available  
**Given** GPS details are available  
**When**  
-	Select the plant Asimina triloba  
-	Add notes: “planted by Brandan Jones”  

**Then**  when I navigate to the Specimen History view, I should see at least one Asimina triloba specimen with the notes, “planted by Brandan Jones”  

2.1  
**Given** a feed of plant data is available  
**Given** GPS details are available  
**When**   
-	Select the plant Malus domestica ‘Fuji’  
-	Take a photo of a Fuji apple seedling  

**Then** when I navigate to the Specimen History view, I should see at least one Malus domestica ‘Fuji’ specimen with the a photo of a Fuji apple seedling.  
## Scrum Roles

- DevOps/Product Owner/Scrum Master: Brandan Jones  
- Frontend Developer: Brandan Jones  
- Integration Developer: Brandan Jones  

## Weekly Meeting

Sunday at 7 PM on Teams







