CREATE SCHEMA IF NOT EXISTS `Rest` DEFAULT CHARACTER SET utf8 ;
USE `Rest` ;

DROP TABLE IF EXISTS `Rest`.`Position` ;
CREATE TABLE IF NOT EXISTS `Rest`.`Position` (
  `idposition` INT NOT NULL,
  `Name` VARCHAR(45) NULL,
  `Price` INT NULL,
  `amountoforder` VARCHAR(45) NULL,
  PRIMARY KEY (`idposition`))
ENGINE = InnoDB;


DROP TABLE IF EXISTS `Rest`.`Product` ;
CREATE TABLE IF NOT EXISTS `Rest`.`Product` (
  `idProduct` INT NOT NULL,
  `Name` VARCHAR(45) NULL,
  `shellife` INT NULL,
  `price` INT NULL,
  PRIMARY KEY (`idProduct`))
ENGINE = InnoDB;


DROP TABLE IF EXISTS `Rest`.`Storage` ;
CREATE TABLE IF NOT EXISTS `Rest`.`Storage` (
  `idgood` INT NOT NULL,
  `Amount` VARCHAR(45) NULL,
  `dateofoldest` DATE NULL,
  `idproduct` INT NULL,
  PRIMARY KEY (`idgood`),
  INDEX `product_idx` (`idproduct` ASC) VISIBLE,
  CONSTRAINT `product`
    FOREIGN KEY (`idproduct`)
    REFERENCES `Rest`.`Product` (`idProduct`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


DROP TABLE IF EXISTS `Rest`.`Employee` ;
CREATE TABLE IF NOT EXISTS `Rest`.`Employee` (
  `idEmployee` INT NOT NULL,
  `Name` VARCHAR(45) NULL,
  `Dateofbirth` DATE NULL,
  `salary` INT NULL,
  `hoursofwork` INT NULL,
  `login` VARCHAR(45) NULL,
  `password` VARCHAR(45) NULL,
  `cellphone` VARCHAR(45) NULL,
  PRIMARY KEY (`idEmployee`))
ENGINE = InnoDB;


DROP TABLE IF EXISTS `Rest`.`Order` ;
CREATE TABLE IF NOT EXISTS `Rest`.`Order` (
  `idOrder` INT NOT NULL AUTO_INCREMENT,
  `date` DATE NULL,
  `time_order` TIME NULL,
  `payment` INT NULL,
  `wayofpayment` VARCHAR(45) NULL,
  `state` VARCHAR(15) NULL,
  `idwaiter` INT NULL,
  `time_control` TIME NULL,
  `total` INT NULL,
  `text` TEXT(200) NULL,
  PRIMARY KEY (`idOrder`),
  INDEX `waiter_idx` (`idwaiter` ASC) VISIBLE,
  CONSTRAINT `waiter`
    FOREIGN KEY (`idwaiter`)
    REFERENCES `Rest`.`Employee` (`idEmployee`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

-- DROP TABLE IF EXISTS `Rest`.`Users`;
-- CREATE TABLE IF NOT EXISTS `Rest`.`Users` (
-- 	user_id INT NOT NULL AUTO_INCREMENT,
--   
DROP TABLE IF EXISTS  `Rest`.`Warehouse`;
CREATE TABLE IF NOT EXISTS `Rest`.`Warehouse` (
	idItem INT NOT NULL AUTO_INCREMENT,
    name TEXT NOT NULL,
    idposition INT NOT NULL,
    quantity INT NOT NULL,
    price INT NOT NULL,
	info TEXT,
    PRIMARY KEY(idItem)
);


DROP TABLE IF EXISTS `Rest`.`Item` ;
CREATE TABLE IF NOT EXISTS `Rest`.`Item` (
  `idItem` INT NOT NULL AUTO_INCREMENT,
  `idposition` INT NULL,
  `quant` INT NULL,
  `total_rice` INT NULL,
  `id_order` INT NULL,
  `State` INT NULL,
  `idcooker` INT NULL,
  `details` VARCHAR(100) NULL,
  PRIMARY KEY (`idItem`),
  INDEX `position_idx` (`idposition` ASC) VISIBLE,
  INDEX `order_idx` (`id_order` ASC) VISIBLE,
  INDEX `cooker_idx` (`idcooker` ASC) VISIBLE,
  CONSTRAINT `position`
    FOREIGN KEY (`idposition`)
    REFERENCES `Rest`.`Position` (`idposition`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `order`
    FOREIGN KEY (`id_order`)
    REFERENCES `Rest`.`Order` (`idOrder`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `cooker`
    FOREIGN KEY (`idcooker`)
    REFERENCES `Rest`.`Employee` (`idEmployee`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

