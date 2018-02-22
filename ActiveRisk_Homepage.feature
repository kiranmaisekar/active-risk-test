Feature: ActiveRisk_Homepage
	Feature to test Risk Managemnet Functionality
	Here we test auto-search and navigating to search result
@SomkeTest
@Browser:Chrome
Scenario: Search for Risk Management in Sword ActiveRisk Homepage
	Given I have naviagted to Sword-ActiveRisk homepage
	And   I see the Homepage Fully Loaded
	When  I type search keyword as
	| Keyword         |
	| Risk Management |        
	Then I should  see the result for Keyword
	| Keyword         |
	| Risk Management |        |