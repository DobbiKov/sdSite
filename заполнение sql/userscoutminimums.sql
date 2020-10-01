-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Сен 27 2020 г., 16:09
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
-- Структура таблицы `userscoutminimums`
--

CREATE TABLE IF NOT EXISTS `userscoutminimums` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` int(11) NOT NULL,
  `iScout1` tinyint(1) NOT NULL,
  `iScout2` tinyint(1) NOT NULL,
  `iScout3` tinyint(1) NOT NULL,
  `iScout4` tinyint(1) NOT NULL,
  `iScout5` tinyint(1) NOT NULL,
  `iScout6` tinyint(1) NOT NULL,
  `iScout7` tinyint(1) NOT NULL,
  `iScout8` tinyint(1) NOT NULL,
  `iScout9` tinyint(1) NOT NULL,
  `iScout10` tinyint(1) NOT NULL,
  `iScout11` tinyint(1) NOT NULL,
  `iScout12` tinyint(1) NOT NULL,
  `iScout13` tinyint(1) NOT NULL,
  `natureLife1` tinyint(1) NOT NULL,
  `natureLife2` tinyint(1) NOT NULL,
  `natureLife3` tinyint(1) NOT NULL,
  `natureLife4` tinyint(1) NOT NULL,
  `natureLife5` tinyint(1) NOT NULL,
  `natureLife6` tinyint(1) NOT NULL,
  `natureLife7` tinyint(1) NOT NULL,
  `natureLife8` tinyint(1) NOT NULL,
  `natureLife9` tinyint(1) NOT NULL,
  `natureLife10` tinyint(1) NOT NULL,
  `natureLife11` tinyint(1) NOT NULL,
  `natureLife12` tinyint(1) NOT NULL,
  `natureLife13` tinyint(1) NOT NULL,
  `natureLife14` tinyint(1) NOT NULL,
  `natureLife15` tinyint(1) NOT NULL,
  `natureLife16` tinyint(1) NOT NULL,
  `lifeInSociety1` tinyint(1) NOT NULL,
  `lifeInSociety2` tinyint(1) NOT NULL,
  `lifeInSociety3` tinyint(1) NOT NULL,
  `lifeInSociety4` tinyint(1) NOT NULL,
  `lifeInSociety5` tinyint(1) NOT NULL,
  `lifeInSociety6` tinyint(1) NOT NULL,
  `lifeInSociety7` tinyint(1) NOT NULL,
  `lifeInSociety8` tinyint(1) NOT NULL,
  `iGood1` tinyint(1) NOT NULL,
  `iGood2` tinyint(1) NOT NULL,
  `iGood3` tinyint(1) NOT NULL,
  `iGood4` tinyint(1) NOT NULL,
  `iGood5` tinyint(1) NOT NULL,
  `iGood6` tinyint(1) NOT NULL,
  `iGood7` tinyint(1) NOT NULL,
  `iGood8` tinyint(1) NOT NULL,
  `iGood9` tinyint(1) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Дамп данных таблицы `userscoutminimums`
--

INSERT INTO `userscoutminimums` (`Id`, `UserId`, `iScout1`, `iScout2`, `iScout3`, `iScout4`, `iScout5`, `iScout6`, `iScout7`, `iScout8`, `iScout9`, `iScout10`, `iScout11`, `iScout12`, `iScout13`, `natureLife1`, `natureLife2`, `natureLife3`, `natureLife4`, `natureLife5`, `natureLife6`, `natureLife7`, `natureLife8`, `natureLife9`, `natureLife10`, `natureLife11`, `natureLife12`, `natureLife13`, `natureLife14`, `natureLife15`, `natureLife16`, `lifeInSociety1`, `lifeInSociety2`, `lifeInSociety3`, `lifeInSociety4`, `lifeInSociety5`, `lifeInSociety6`, `lifeInSociety7`, `lifeInSociety8`, `iGood1`, `iGood2`, `iGood3`, `iGood4`, `iGood5`, `iGood6`, `iGood7`, `iGood8`, `iGood9`) VALUES
(1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(2, 3, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
