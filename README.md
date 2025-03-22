# 🎉 Application de Gestion de Tournois Sportifs 🏆

## 📖 Sommaire
1. [📌 Description](#-description)
2. [🚀 Fonctionnalités](#-fonctionnalités)
3. [ 🛠️ Technologies utilisées](#technologies-utilisées)
4. [📥 Installation](#-installation)
5. [📂 Structure du Projet](#-structure-du-projet)
6. [👨‍💻 Auteurs](#-auteurs)
---

## 📌 Description
Cette application permet la gestion et la consultation des tournois sportifs organisés dans un complexe multisports. Elle est développée en **C# avec WPF et LINQ** et s'appuie sur une base de données **MySQL**.

## 🚀 Fonctionnalités
### 🔐 Gestionnaire (Administrateur)
- **S'authentifier** via un login/mot de passe
- **Gérer les sports** (ajout, modification, suppression)
- **Gérer les tournois** (ajout, modification, suppression)
- **Gérer les participants** (ajout, modification, suppression)
- **Gérer les gestionnaires** (ajout, modification, suppression)

### 👤 Utilisateur Simple
- **Consulter les participants** (tri possible par ID, nom ou prénom)
- **Rechercher un participant uniquement par son nom**
- **Rechercher les participants par tournoi**
- **Rechercher les tournois par sport**

## 🛠️ Technologies utilisées
- **Langages** : C#, XAML, LINQ
- **Framework** : .NET Framework (WPF)
- **Base de données** : MySQL
- **ORM** : LINQ avec Devart LINQConnect Express
- **Environnement** : Visual Studio 2022

## 📥 Installation
### 1️⃣ Configuration de la Base de Données
1. **Installer XAMPP** pour bénéficier de **Apache et MySQL**.
2. **Lancer Apache et MySQL** depuis le panneau de contrôle XAMPP.
3. **Ouvrir PhpMyAdmin** : [localhost/phpmyadmin](http://localhost/phpmyadmin)
4. **Exécuter les scripts SQL** :
   - D'abord **`scriptBddTournois.sql`** pour créer la base de données.
   - Ensuite **`ScriptPeuplerBdd.sql`** pour insérer les données initiales.
5. **Vérifier la connexion à la BDD** avec les paramètres :
   - **IP** : `localhost`
   - **Port** : `3306`
   - **Utilisateur** : `adminTournois`
   - **Mot de passe** : `Password1234@`
   - **Nom de la base** : `bddtournois`

### 2️⃣ Installation du Projet
1. **Cloner ce dépôt** :
   ```sh
   git clone https://github.com/ton-repo/tournoi.git
   ```
2. **Ouvrir la solution** `SolutionTournoi.sln` avec **Visual Studio**.
3. **Installer Devart LINQConnect Express** si ce n'est pas déjà fait.
4. **Configurer la connexion à la BDD** dans `App.config`.
5. **Lancer l'application** 🎉

## 📂 Structure du Projet
- 📁 `SolutionTournoi/`
  - 📂 `AppTournoi/` : Application principale en WPF
  - 📂 `DllTournois/` : Bibliothèque pour la gestion de la BDD via LINQ
  - 📂 `ScriptsSQL/` : Scripts pour la base de données
  - 📄 `README.md` : Ce fichier 😊

## 👨‍💻 Auteurs
Projet développé par **Cyprien Duroy** et **Alexandre Le Roy** dans le cadre du cours **Architecture Logicielle** du **BUT Informatique - 2025**. 🚀
