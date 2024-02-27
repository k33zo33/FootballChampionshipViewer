Project Description: World Cup Statistics Viewer

This project aims to create three applications for displaying statistics from the 2018 Men's World Cup and the 2019 Women's World Cup using the provided API. The applications include a Windows Forms application, a Windows Presentation Foundation (WPF) application, and a Data Layer responsible for data manipulation shared between both client applications.
Data Layer (Class Library)

The Data Layer serves as a centralized module for data manipulation and is utilized by both client applications. Its responsibilities include:

    Retrieving data from the specified API and parsing it
    Mapping retrieved data for use in client applications
    Storing data in text files for offline use
    Providing functionality to read data from text files
    Handling data retrieval from API endpoints or JSON files based on user configuration

API endpoints provide information about national teams, matches, and match details for both the Men's and Women's World Cup championships.
Windows Forms Application

The Windows Forms application focuses on functionality and user interaction, with a primary emphasis on logical interface design and usability. Key features include:

    Asynchronous data retrieval to ensure smooth user experience
    Initial setup allowing users to set preferences such as preferred championship and language
    Favorite national team selection and storage for subsequent launches
    Favorite player selection with drag-and-drop functionality and persistence
    Player picture assignment with default image fallback
    Player ranking lists based on goals scored and yellow cards
    Ability to print ranking lists for reference
    User-friendly settings interface for application configuration
    Confirmation prompts for application closure

Windows Presentation Foundation (WPF) Application

The WPF application prioritizes responsiveness and modern interface design. It shares basic settings with the Windows Forms application and offers additional features, including:

    Initial setup for user preferences, including championship, language, and display mode
    Overview of selected national teams with match results
    Detailed information window for each national team
    Visual representation of starting lineups on a football field background
    Player overview with detailed statistics and information
    Seamless integration with application settings and confirmation prompts for changes and closures
