                            Projet Boost DotNet - ARONAINASOA Yisraèl Qadmièlslloos
Bienvenue dans le dépôt du projet Boost DotNet, réalisé par ARONAINASOA Yisraèl Qadmièlslloos, étudiant en DA2I L3 (Informatique) à l'EMIT Fianarantsoa, numéro d'inscription 016I23. Ce projet est une application développée avec .NET pour démontrer des compétences en développement web, gestion de bases de données et création d'API.
📖 Description du projet : Boost DotNet est une application web développée avec le framework .NET Core, conçue pour un bref exemple de gestion des clients. Elle utilise une architecture moderne avec une base de données relationnelle (via un fichier SQL) et une interface utilisateur accessible.

Objectifs du projet :
- Démontrer la maîtrise des concepts de développement avec .NET Core (API REST, Entity Framework, etc.).
- Implémenter une gestion efficace des données avec une base de données relationnelle.
- Fournir une interface utilisateur simple et intuitive (si applicable).
- Appliquer les bonnes pratiques de gestion de code avec Git et GitHub.


🛠️ Technologies utilisées :
- .NET Core : Framework principal pour le backend.
- Entity Framework Core : ORM pour interagir avec la base de données.
- SQL : Gestion des données via le fichier database/dotnet.sql.
- ASP.NET Core : Pour la création d'une API RESTful.
- C# : Langage principal pour le développement.
- Git : Contrôle de version pour gérer le code source.


📂 Structure du projet :
Voici une vue d'ensemble des principaux fichiers et dossiers du projet :
- AppDbContext.cs : Contexte de la base de données pour Entity Framework.
- Controllers/ : Contient les contrôleurs de l'API REST.
- Models/ : Modèles de données utilisés dans l'application.
- Migrations/ : Fichiers de migration pour la base de données.
- database/dotnet.sql : Script SQL pour la création et l'initialisation de la base de données.
- MonApiCrud.csproj : Fichier de projet .NET.
- Program.cs : Point d'entrée de l'application.
- wwwroot/ : Dossier pour les fichiers statiques (CSS, JavaScript, etc.).


🚀 Comment exécuter le projet :
Prérequis :
- .NET SDK (version 6.0 ou supérieure recommandée).
- Un serveur de base de données (par exemple, SQL Server ou SQLite).
- Git pour cloner le dépôt.
- Un IDE comme Visual Studio Code ou Visual Studio.

Étapes d'installation:
- Cloner le dépôt : git clone https://github.com/YaroRael/Boost-dotnet-ARONAINASOA-Yisrael-Qadmielslloos-DA2I-L3-016I23.git
- cd Boost-dotnet-ARONAINASOA-Yisrael-Qadmielslloos-DA2I-L3-016I23
- Restaurer les dépendances : dotnet restore
- Configurer la base de données c'est-à-dire exécute le script SQL database/dotnet.sql dans ton gestionnaire de base de données (par exemple, SQL Server Management Studio ou SQLite).
- Mets à jour la chaîne de connexion dans appsettings.json si nécessaire.
- Exécuter l'application : dotnet run


L'application sera accessible à l'adresse http://localhost:5000.


📜 Instructions pour contribuer :
Si tu souhaites contribuer à ce projet :
- Fork le dépôt sur GitHub.
- Crée une branche pour tes modifications :git checkout -b nom-de-ta-branche
- Fais tes modifications et commit :git commit -m "Description de tes changements"
- Pousse tes modifications :git push origin nom-de-ta-branche
- Ouvre une Pull Request sur GitHub.


📝 Avertissements
- Le dossier contient des accents sous le nom : ARONAINASOA Yisraèl Qadmièlslloos-DA2I L3-016I23.
- Les dossiers bin/ et obj/ sont générés automatiquement et ne doivent pas être inclus dans le dépôt. Un fichier .gitignore est fourni pour exclure ces fichiers.


📚 Ressources :
- Documentation .NET Core
- Documentation Entity Framework Core
- GitHub
