-- MySQL Script generated by MySQL Workbench
-- Fri Oct 28 21:11:16 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema MiLogin
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema MiLogin
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `MiLogin` DEFAULT CHARACTER SET utf8 ;
USE `MiLogin` ;

-- -----------------------------------------------------
-- Table `MiLogin`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `MiLogin`.`Usuario` (
  `Codigo` NVARCHAR(20) NOT NULL,
  `Nombre` NVARCHAR(50) NOT NULL,
  `Clave` NVARCHAR(100) NOT NULL,
  `Correo` NVARCHAR(45) NULL,
  `Rool` NVARCHAR(20) NOT NULL,
  `EstaActivo` TINYINT NOT NULL,
  PRIMARY KEY (`Codigo`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
