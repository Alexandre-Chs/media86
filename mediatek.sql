-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : sam. 24 fév. 2024 à 12:56
-- Version du serveur : 8.2.0
-- Version de PHP : 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16 COLLATE=utf16_bin;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(4, '2024-04-24 00:00:00', '2026-02-13 00:00:00', 2),
(7, '2024-09-14 00:00:00', '2025-04-30 00:00:00', 2),
(3, '2025-02-17 00:00:00', '2025-03-28 00:00:00', 1),
(7, '2023-03-25 00:00:00', '2025-09-03 00:00:00', 2),
(4, '2024-02-24 00:00:00', '2024-02-24 00:00:00', 1),
(9, '2023-09-01 00:00:00', '2026-02-28 00:00:00', 1),
(2, '2024-02-27 00:00:00', '2025-09-11 00:00:00', 2),
(7, '2024-06-18 00:00:00', '2026-04-15 00:00:00', 3),
(8, '2023-12-04 00:00:00', '2026-01-22 00:00:00', 3),
(8, '2024-02-22 00:00:00', '2025-06-24 00:00:00', 2),
(7, '2023-04-19 00:00:00', '2026-08-14 00:00:00', 1),
(5, '2023-08-26 00:00:00', '2025-11-05 00:00:00', 2),
(5, '2024-04-28 00:00:00', '2026-02-20 00:00:00', 1),
(4, '2024-02-14 00:00:00', '2024-02-24 00:00:00', 4),
(6, '2024-09-17 00:00:00', '2026-05-15 00:00:00', 2),
(8, '2024-01-27 00:00:00', '2026-01-14 00:00:00', 2),
(9, '2024-08-22 00:00:00', '2025-07-27 00:00:00', 2),
(10, '2024-03-15 00:00:00', '2026-05-02 00:00:00', 1),
(6, '2024-02-24 00:00:00', '2024-02-24 00:00:00', 1),
(2, '2024-08-17 00:00:00', '2025-12-06 00:00:00', 3),
(9, '2024-03-02 00:00:00', '2025-03-24 00:00:00', 2),
(6, '2024-11-08 00:00:00', '2025-06-14 00:00:00', 2),
(9, '2024-05-05 00:00:00', '2025-09-10 00:00:00', 3),
(9, '2023-07-31 00:00:00', '2025-10-13 00:00:00', 2),
(4, '2023-07-27 00:00:00', '2025-05-23 00:00:00', 2),
(10, '2024-06-04 00:00:00', '2025-07-03 00:00:00', 1),
(7, '2025-02-03 00:00:00', '2025-08-20 00:00:00', 3),
(8, '2024-11-28 00:00:00', '2026-07-21 00:00:00', 2),
(6, '2024-04-25 00:00:00', '2026-07-31 00:00:00', 2),
(6, '2024-07-18 00:00:00', '2025-11-04 00:00:00', 3),
(7, '2025-02-08 00:00:00', '2025-09-17 00:00:00', 2),
(7, '2024-01-29 00:00:00', '2026-08-26 00:00:00', 2),
(8, '2024-12-07 00:00:00', '2026-03-23 00:00:00', 2),
(9, '2023-09-11 00:00:00', '2025-03-13 00:00:00', 3),
(7, '2024-02-21 00:00:00', '2026-06-17 00:00:00', 3),
(2, '2023-08-03 00:00:00', '2025-10-04 00:00:00', 2),
(9, '2024-08-10 00:00:00', '2025-06-12 00:00:00', 2),
(6, '2024-12-21 00:00:00', '2026-03-06 00:00:00', 2),
(5, '2024-12-12 00:00:00', '2026-02-11 00:00:00', 2),
(9, '2024-08-19 00:00:00', '2026-09-01 00:00:00', 2),
(2, '2023-09-23 00:00:00', '2026-07-26 00:00:00', 3),
(8, '2023-07-01 00:00:00', '2026-03-02 00:00:00', 1),
(9, '2023-07-21 00:00:00', '2025-03-04 00:00:00', 3),
(6, '2023-11-03 00:00:00', '2026-04-02 00:00:00', 1),
(6, '2024-01-25 00:00:00', '2026-06-16 00:00:00', 2),
(6, '2023-11-09 00:00:00', '2025-08-18 00:00:00', 2);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf16_bin DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf16 COLLATE=utf16_bin;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf16_bin DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf16_bin DEFAULT NULL,
  `tel` varchar(15) COLLATE utf16_bin DEFAULT NULL,
  `mail` varchar(128) COLLATE utf16_bin DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=utf16 COLLATE=utf16_bin;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(2, 'Martin', 'Pierre', '0234567891', 'pierre.martin@example.com', 2),
(3, 'Lefevre', 'Marie', '0345678912', 'marie.lefevre@example.com', 3),
(4, 'Girard', 'Sophie', '0456789123', 'sophie.girard@example.com', 1),
(5, 'Moreau', 'Luc', '0567891234', 'luc.moreau@example.com', 2),
(6, 'Lambert', 'Camille', '0678912345', 'camille.lambert@example.com', 3),
(7, 'Roux', 'Alexandre', '0789123456', 'alexandre.roux@example.com', 1),
(8, 'Vincent', 'Julie', '0891234567', 'julie.vincent@example.com', 2),
(9, 'Leroy', 'Nicolas', '0912345678', 'nicolas.leroy@example.com', 3),
(10, 'Petit', 'Emma', '0123456789', 'emma.petit@example.com', 1),
(16, 'personnel1', 'personnel2', '2121211', 'mail@gmail.com', 3);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf16_bin NOT NULL,
  `pwd` varchar(64) CHARACTER SET utf16 COLLATE utf16_bin NOT NULL,
  UNIQUE KEY `id` (`login`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16 COLLATE=utf16_bin;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('media', '721c9525ade2ea8903d343ef25cf68b9bf4ab0aad56bb7b01fbe48d09bc7fcf4');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf16_bin DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf16 COLLATE=utf16_bin;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
