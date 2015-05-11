#Compte rendu Génie Logiciel#
***

## **Projet Génie Logiciel**

**Participants au projet**

 - Nicolas Notari
 - Guillaume Thomas
 - Damien Jacquet
 - Simon Conejo
 - Aurélien Saudemont

--------------

# Introduction

L'atelier de Génie Logiciel est un cours nous apprenant les différentes étapes de la réalisation d'une application, de sa conception à sa réalisation et sa publication. Un projet est donné à la fin permettant de mettre en oeuvre les différentes choses apprisent durant le cours.

## MOA TicTacToe

Dans ce projet, nous avons eu à faire le rôle de MOA (Maitrise d'Ouvrage) et de MOE (Maitrise d'Oeuvre) ainsi que le développement complet du projet.

Nous avons ainsi joué le rôle de MOA pour le projet "TicTacToe". Nous avons donc dû rédiger un cahier des charges ainsi que des spécifications fonctionnelles. Les personne du groupe Puissance 4 ont fait la même chose pour notre projet, en temps que notre MOA.
L'évolution demandée à la MOE du TicTacToe fut la sauvegarde de la partie au format JSON.

***

## MOE Pendu

Suite à notre cours de Génie Logiciel, nous avons dû, afin de mettre en pratique les différents cours donnés auparavant par Mr Alexandre Boyer, faire un projet en équipe. Ce projet devait respecter les différentes normes et patrons d'architectures appris durant les cours de Géniel Logiciel :

 - **Git** afin de faciliter le développement en équipe
 - Utilisation d'**injection de dépendance**
 - Inversion de contrôle **IOC**  
 - Single Responsibility Principle  **SRP**  

Afin de réaliser ce projet, nous avons d'utilisé le langage **C#**, un langage que nous avons dû apprendre car nous n'avons pas eu de cours sur ce dernier. Il est cependant assez proche du langage C++ que nous avions appris durant notre DUT informatique ainsi que du langage Java. 

L'IDE que nous avons utilisé est **Visual Studio**, dans sa dernière version (2013). Cet IDE, conçu par Microsoft, est spécialement conçu autour du C et de ses dérivés (C++/C#), il est donc adapté à notre utilisation. De plus, il possède de nombreux outils intégrés et très ergonomique concernant l'auto-complétement, l'automatisation de tâches, la création de tests unitaires ainsi qu'un client Git intégré.

### Principe du projet

Le cahier des charges établit par notre MOA stipule que ce projet doit être un jeu de Pendu classique, réalisé sur une console et jouable uniquement au clavier. Il dois être programmé en langage C# et devra respecter certaines règles, comme posséder un dictionnaire local, afficher une image représentant le pendu, ou encore l'affichage des règles à la demande de l'utilisateur.

### Début du Projet

La première étape du projet fut de lire le cahier des charges fournit par notre MOA. Ensuite nous avons établi les différentes fonctions de notre application. Une fois les principales fonctions décidées nous avons réparti ces fonctions entre nous. Il ne restait plus qu'à développer les différentes fonctions données à chacun. La répartition du travail s'est faites en fonction des demandes et des préférences de chaques développeurs.

### Injection de dépendances

L'utilisation du mécanisme d'injection de dépendances nous a permis d'éviter la création d'objet et d'éviter un fort couplage entre des classes en utilisant des interfaces, ce qui nous permet de modifier les implémentations en limitant les impacts sur le reste du programme (principe d'Hollywood : "Ne nous appelez pas, c'est nous qui vous appellerons").

### Single Responsibility Principle

Le Single Responsibility Principle (SRP) est une manière de coder qui revient simplement à dire qu'une classe n'a qu'une seule et unique fonction. Cela permet de plus facilement débuger son code en cas de problème et également de voir quelle fonction pose problème en cas d'erreur dans les résultats attendus.

### Les tests unitaires

Chaque développeur a dû écrire des tests unitaires pour valider son code.

Nous avons décidé que la série de tests unitaires devaient être lancée avant chaque commit afin d'éviter les erreurs de programmation et de s'assurer qu'il n'y avait pas de régression.  

***

## Organisation

Dans un premier temps, nous nous sommes partagés les tâches en faisant une équipe MOA (Simon, Damien et Aurélien) et une équipe MOE (Nicolas et Guillaume), puis nous avons eu des activités transverses.  

***

# Conclusion

Le projet fut très intéressant, notamment sous plusieurs aspects.  
Le premier aspect fut d'être à la fois MOA et MOE. La gestion en tant que MOA d'un autre groupe permettait d'avoir les deux visions complémentaires d'un projet.  
Le deuxième aspect fut de coder de façon "propre". En effet, en plus de devoir réaliser l'application nous devions faire en sorte que celle-ci soit maintenable et évolutive.
