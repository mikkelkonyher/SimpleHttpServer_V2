Use case navn:	Lommeregner – Læg to tal sammen

Scenarie:	En bruger tilgår vores webserver, hvor der findes et helt basic eksempel på en lommeregner, der lægger to tal sammen. Bruger indtaster to tal i hver deres felt og trykker på add knappen på skærmen. Systemet returnerer derefter resultatet.

Udløsende begivenhed:	En bruger ønsker at lægge to tal sammen.

Beskrivelse (brief):	1. Brugeren tilgår vores webserver på IP xxx.xxx.x.x:8080.
2. Brugeren taster 2 tal i hver deres felt.
3. Brugeren klikker på add knappen på skærmen.
4. Resultatet vises på skærmen.

Aktører:	Bruger, Webserver

Prebetingelser:	Brugeren har vores IP og adgang til internettet.

Postbetingelser: Brugeren får resultatet af beregningen.

Flow af aktiviteter:	

Aktør	System:
1. Brugeren tilgår vores webserver.
2. Brugeren indtaster to tal og trykker på add knappen på skærmen.
3. Resultatet vises på skærmen.
	1.1	Html siden vises.
3.1 Koden bag webserveren udregner summen af de to tal og viser dem på skærmen.

------------------------------------------------------------------------------

Use case navn:	Lommeregner – Multiplicer to tal

Scenarie:	En bruger tilgår vores webserver, hvor der findes et helt basic eksempel på en lommeregner, der multiplicerer to tal. Bruger indtaster to tal i hver deres felt og trykker på multiply knappe på skærmen. Systemet returnerer derefter resultatet.

Udløsende begivenhed:	En bruger ønsker at multiplicere to tal.

Beskrivelse (brief):	1. Brugeren tilgår vores webserver på IP xxx.xxx.x.x:8080.
2. Brugeren taster 2 tal i hver deres felt.
3. Brugeren klikker på multiply knappen på skærmen.
4. Resultatet vises på skærmen.

Aktører:	Bruger, Webserver

Prebetingelser:	Brugeren har vores IP og adgang til internettet.

Postbetingelser: Brugeren får resultatet af beregningen.

Flow af aktiviteter:

Aktør	System:
1. Brugeren tilgår vores webserver.
2. Brugeren indtaster to tal og trykker på multiply knappen på skærmen.
3. Resultatet vises på skærmen.
	1.1	Html siden vises.
3.1 Koden bag webserveren udregner summen af de to tal og viser dem på skærmen.

------------------------------------------------------------------------------

Use case navn:	Lommeregner – Accepter decimal tal

Scenarie:	En bruger ønsker at indtaste et decimal tal på websidens lommeregner.

Udløsende begivenhed:	En bruger ønsker at beregne to decimal tal.

Beskrivelse (brief):	1. Brugeren tilgår vores webserver på IP xxx.xxx.x.x:8080.
2. Brugeren taster 2 deicmal tal i hver deres felt.
3. Brugeren klikker på add eller multiply knappen på skærmen.
4. Resultatet vises på skærmen.

Aktører:	Bruger, Webserver

Prebetingelser:	Brugeren har vores IP og adgang til internettet.

Postbetingelser: Brugeren får resultatet af beregningen.

Flow af aktiviteter:

Aktør	System:
1. Brugeren tilgår vores webserver.
2. Brugeren indtaster to decimal tal og trykker på add eller multiply knappen på skærmen.
3. Resultatet vises på skærmen.
	1.1	Html siden vises.
3.1 Koden bag webserveren udregner summen af de to tal og viser dem på skærmen.







