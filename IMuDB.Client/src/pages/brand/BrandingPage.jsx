import React from 'react';
import classes from './BrandingPage.module.css';
import { BrandSection } from './components/BrandSection';
import { TypographyBrand } from './components/TypographyBrand';
import { ColorBrand } from './components/ColorBrand';
import { ButtonBrand } from './components/ButtonBrand';

export default function BrandingPage() {
	return (
		<div className={`grid grid-col-3 gap-s ${classes.brand_content}`}>
			<BrandSection header={'Typography'}>
				<TypographyBrand />
			</BrandSection>
			<BrandSection header={'Colors'}>
				<ColorBrand />
			</BrandSection>
			<BrandSection header={'Buttons'}>
				<ButtonBrand />
			</BrandSection>
		</div>
	);
}
