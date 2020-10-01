-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Сен 27 2020 г., 16:10
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `sdsite`
--

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `Id` bigint(20) NOT NULL AUTO_INCREMENT,
  `UserName` longtext CHARACTER SET utf8mb4,
  `FirstName` longtext CHARACTER SET utf8mb4,
  `LastName` longtext CHARACTER SET utf8mb4,
  `ForestName` longtext CHARACTER SET utf8mb4,
  `Password` longtext CHARACTER SET utf8mb4,
  `SiteRoleId` int(11) NOT NULL,
  `JWTToken` longtext CHARACTER SET utf8mb4,
  `Class` int(11) NOT NULL DEFAULT '0',
  `HomeAdress` longtext CHARACTER SET utf8mb4,
  `Passport` longtext CHARACTER SET utf8mb4,
  `PhoneNumber` longtext CHARACTER SET utf8mb4,
  `School` longtext CHARACTER SET utf8mb4,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`Id`, `UserName`, `FirstName`, `LastName`, `ForestName`, `Password`, `SiteRoleId`, `JWTToken`, `Class`, `HomeAdress`, `Passport`, `PhoneNumber`, `School`) VALUES
(1, 'sa', 'Системный', 'Администратор', 'System Admin', '8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918', 5, 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InNhIiwic3ViIjoiMSIsInJvbGUiOiI1IiwiZXhwIjoxNjAxMjE1Mzg2LCJpc3MiOiJhdXRoU2VydmVyIiwiYXVkIjoicmVzb3VyY2VTZXJ2ZXIifQ.U8krLsdfuytyoWq_KtkUrD5dlhhdE0fPTJx6MCre-2M', 9, 'pravoberezhna', 'das', '=38', 'n91'),
(3, 'tester', 'tester', 'tester', 'tester', '9BBA5C53A0545E0C80184B946153C9F58387E3BD1D4EE35740F29AC2E718B019', 1, NULL, 0, NULL, NULL, NULL, NULL);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
