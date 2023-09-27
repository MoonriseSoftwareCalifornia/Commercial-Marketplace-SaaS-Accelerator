﻿namespace Marketplace.SaaS.Accelerator.Services.Utilities;
public static class EmailTemplates
{
    /// <summary>
    /// This is a standard blank template for email
    /// </summary>
    /// <remarks>Replate {{{TITLE}}} with the title of the Email, and replace {{{BODY}}} with the body of the Email.</remarks>
    public const string StandardBlankTemplate = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\"><html xmlns=\"http://www.w3.org/1999/xhtml\" xmlns:o=\"urn:schemas-microsoft-com:office:office\"><head><meta charset=\"UTF-8\"><meta content=\"width=device-width,initial-scale=1\" name=\"viewport\"><meta name=\"x-apple-disable-message-reformatting\"><meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\"><meta content=\"telephone=no\" name=\"format-detection\"><title>New message</title><!--[if (mso 16)]><style type=\"text/css\">a{text-decoration:none}</style><![endif]--><!--[if gte mso 9]><style>sup{font-size:100%!important}</style><![endif]--><!--[if gte mso 9]><xml><o:officedocumentsettings><o:allowpng></o:allowpng><o:pixelsperinch>96</o:pixelsperinch></o:officedocumentsettings></xml><![endif]--><style type=\"text/css\">#outlook a{padding:0}.es-button{mso-style-priority:100!important;text-decoration:none!important}a[x-apple-data-detectors]{color:inherit!important;text-decoration:none!important;font-size:inherit!important;font-family:inherit!important;font-weight:inherit!important;line-height:inherit!important}.es-desk-hidden{display:none;float:left;overflow:hidden;width:0;max-height:0;line-height:0;mso-hide:all}@media only screen and (max-width:600px){a,ol li,p,ul li{line-height:150%!important}h1,h1 a,h2,h2 a,h3,h3 a{line-height:120%!important}h1{font-size:36px!important;text-align:left}h2{font-size:26px!important;text-align:left}h3{font-size:20px!important;text-align:left}.es-content-body h1 a,.es-footer-body h1 a,.es-header-body h1 a{font-size:36px!important;text-align:left}.es-content-body h2 a,.es-footer-body h2 a,.es-header-body h2 a{font-size:26px!important;text-align:left}.es-content-body h3 a,.es-footer-body h3 a,.es-header-body h3 a{font-size:20px!important;text-align:left}.es-menu td a{font-size:12px!important}.es-header-body a,.es-header-body ol li,.es-header-body p,.es-header-body ul li{font-size:14px!important}.es-content-body a,.es-content-body ol li,.es-content-body p,.es-content-body ul li{font-size:14px!important}.es-footer-body a,.es-footer-body ol li,.es-footer-body p,.es-footer-body ul li{font-size:14px!important}.es-infoblock a,.es-infoblock ol li,.es-infoblock p,.es-infoblock ul li{font-size:12px!important}[class=gmail-fix]{display:none!important}.es-m-txt-c,.es-m-txt-c h1,.es-m-txt-c h2,.es-m-txt-c h3{text-align:center!important}.es-m-txt-r,.es-m-txt-r h1,.es-m-txt-r h2,.es-m-txt-r h3{text-align:right!important}.es-m-txt-l,.es-m-txt-l h1,.es-m-txt-l h2,.es-m-txt-l h3{text-align:left!important}.es-m-txt-c img,.es-m-txt-l img,.es-m-txt-r img{display:inline!important}.es-button-border{display:inline-block!important}a.es-button,button.es-button{font-size:20px!important;display:inline-block!important}.es-adaptive table,.es-left,.es-right{width:100%!important}.es-content,.es-content table,.es-footer,.es-footer table,.es-header,.es-header table{width:100%!important;max-width:600px!important}.es-adapt-td{display:block!important;width:100%!important}.adapt-img{width:100%!important;height:auto!important}.es-m-p0{padding:0!important}.es-m-p0r{padding-right:0!important}.es-m-p0l{padding-left:0!important}.es-m-p0t{padding-top:0!important}.es-m-p0b{padding-bottom:0!important}.es-m-p20b{padding-bottom:20px!important}.es-hidden,.es-mobile-hidden{display:none!important}table.es-desk-hidden,td.es-desk-hidden,tr.es-desk-hidden{width:auto!important;overflow:visible!important;float:none!important;max-height:inherit!important;line-height:inherit!important}tr.es-desk-hidden{display:table-row!important}table.es-desk-hidden{display:table!important}td.es-desk-menu-hidden{display:table-cell!important}.es-menu td{width:1%!important}.esd-block-html table,table.es-table-not-adapt{width:auto!important}table.es-social{display:inline-block!important}table.es-social td{display:inline-block!important}.es-m-p5{padding:5px!important}.es-m-p5t{padding-top:5px!important}.es-m-p5b{padding-bottom:5px!important}.es-m-p5r{padding-right:5px!important}.es-m-p5l{padding-left:5px!important}.es-m-p10{padding:10px!important}.es-m-p10t{padding-top:10px!important}.es-m-p10b{padding-bottom:10px!important}.es-m-p10r{padding-right:10px!important}.es-m-p10l{padding-left:10px!important}.es-m-p15{padding:15px!important}.es-m-p15t{padding-top:15px!important}.es-m-p15b{padding-bottom:15px!important}.es-m-p15r{padding-right:15px!important}.es-m-p15l{padding-left:15px!important}.es-m-p20{padding:20px!important}.es-m-p20t{padding-top:20px!important}.es-m-p20r{padding-right:20px!important}.es-m-p20l{padding-left:20px!important}.es-m-p25{padding:25px!important}.es-m-p25t{padding-top:25px!important}.es-m-p25b{padding-bottom:25px!important}.es-m-p25r{padding-right:25px!important}.es-m-p25l{padding-left:25px!important}.es-m-p30{padding:30px!important}.es-m-p30t{padding-top:30px!important}.es-m-p30b{padding-bottom:30px!important}.es-m-p30r{padding-right:30px!important}.es-m-p30l{padding-left:30px!important}.es-m-p35{padding:35px!important}.es-m-p35t{padding-top:35px!important}.es-m-p35b{padding-bottom:35px!important}.es-m-p35r{padding-right:35px!important}.es-m-p35l{padding-left:35px!important}.es-m-p40{padding:40px!important}.es-m-p40t{padding-top:40px!important}.es-m-p40b{padding-bottom:40px!important}.es-m-p40r{padding-right:40px!important}.es-m-p40l{padding-left:40px!important}.es-desk-hidden{display:table-row!important;width:auto!important;overflow:visible!important;max-height:inherit!important}button.es-button{width:100%}}</style></head><body style=\"width:100%;font-family:arial,'helvetica neue',helvetica,sans-serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0\"><div class=\"es-wrapper-color\" style=\"background-color:#fafafa\"><!--[if gte mso 9]><v:background xmlns:v=\"urn:schemas-microsoft-com:vml\" fill=\"t\"><v:fill type=\"tile\" color=\"#fafafa\"></v:fill></v:background><![endif]--><table class=\"es-wrapper\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0;padding:0;Margin:0;width:100%;height:100%;background-repeat:repeat;background-position:center top;background-color:#fafafa\"><tr><td valign=\"top\" style=\"padding:0;Margin:0\"><table cellpadding=\"0\" cellspacing=\"0\" class=\"es-header\" align=\"center\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0;table-layout:fixed!important;width:100%;background-color:transparent;background-repeat:repeat;background-position:center top\"><tr><td align=\"center\" style=\"padding:0;Margin:0\"><table bgcolor=\"#ffffff\" class=\"es-header-body\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0;background-color:transparent;width:600px\"><tr><td align=\"left\" style=\"padding:20px;Margin:0\"><table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0\"><tr><td class=\"es-m-p0r\" valign=\"top\" align=\"center\" style=\"padding:0;Margin:0;width:560px\"><table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" role=\"presentation\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0\"><tr><td align=\"center\" style=\"padding:0;Margin:0;padding-bottom:10px;font-size:0\"><img src=\"https://xsljna.stripocdn.email/content/guids/CABINET_daf913af885f3458224a33f2e46e91eb950e50e0d4a0185d1a27c861a34a21d4/images/primarylogo_purple.png\" alt=\"Logo\" style=\"display:block;border:0;outline:0;text-decoration:none;-ms-interpolation-mode:bicubic;font-size:12px\" width=\"200\" title=\"Logo\"></td></tr></table></td></tr></table></td></tr></table></td></tr></table><table cellpadding=\"0\" cellspacing=\"0\" class=\"es-content\" align=\"center\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0;table-layout:fixed!important;width:100%\"><tr><td align=\"center\" style=\"padding:0;Margin:0\"><table bgcolor=\"#ffffff\" class=\"es-content-body\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0;background-color:#fff;width:600px\"><tr><td align=\"left\" style=\"padding:0;Margin:0;padding-top:15px;padding-left:20px;padding-right:20px\"><table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0\"><tr><td align=\"center\" valign=\"top\" style=\"padding:0;Margin:0;width:560px\"><table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" role=\"presentation\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0\"><tr><td align=\"center\" class=\"es-m-txt-c\" style=\"padding:0;Margin:0;padding-bottom:10px\"><h1 style=\"Margin:0;line-height:26px;mso-line-height-rule:exactly;font-family:arial,'helvetica neue',helvetica,sans-serif;font-size:28px;font-style:normal;font-weight:700;color:#333\">{{{TITLE}}}</h1></td></tr></table></td></tr></table></td></tr></table></td></tr></table><table cellpadding=\"0\" cellspacing=\"0\" class=\"es-content\" align=\"center\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0;table-layout:fixed!important;width:100%\"><tr><td align=\"center\" style=\"padding:0;Margin:0\"><table bgcolor=\"#ffffff\" class=\"es-content-body\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0;background-color:#fff;width:600px\"><tr><td align=\"left\" style=\"Margin:0;padding-bottom:10px;padding-top:20px;padding-left:20px;padding-right:20px\"><table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0\"><tr><td align=\"center\" valign=\"top\" style=\"padding:0;Margin:0;width:560px\">{{{BODY}}}</td></tr></table></td></tr><tr><td align=\"left\" style=\"Margin:0;padding-bottom:10px;padding-top:15px;padding-left:20px;padding-right:20px\"><table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0\"><tr><td align=\"left\" style=\"padding:0;Margin:0;width:560px\"><table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" role=\"presentation\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0\"><tr><td align=\"center\" style=\"padding:0;Margin:0;padding-top:10px;padding-bottom:10px\"><p style=\"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:arial,'helvetica neue',helvetica,sans-serif;line-height:21px;color:#333;font-size:14px\">Have a question?&nbsp;Email us at&nbsp;<a target=\"_blank\" href=\"mailto:notifications@comosws.io\" style=\"-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decoration:underline;color:#5c68e2;font-size:14px\">Customer Support</a>&nbsp;or give us a call at&nbsp;<a target=\"_blank\" href=\"\" style=\"-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decoration:underline;color:#5c68e2;font-size:14px\">+1 (530) 382-7867</a>.</p></td></tr></table></td></tr></table></td></tr></table></td></tr></table><table cellpadding=\"0\" cellspacing=\"0\" class=\"es-footer\" align=\"center\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0;table-layout:fixed!important;width:100%;background-color:transparent;background-repeat:repeat;background-position:center top\"><tr><td align=\"center\" style=\"padding:0;Margin:0\"><table class=\"es-footer-body\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0;background-color:transparent;width:600px\"><tr><td align=\"left\" style=\"Margin:0;padding-top:20px;padding-bottom:20px;padding-left:20px;padding-right:20px\"><table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0\"><tr><td align=\"left\" style=\"padding:0;Margin:0;width:560px\"><table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" role=\"presentation\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0\"><tr><td align=\"center\" style=\"padding:0;Margin:0;padding-top:15px;padding-bottom:15px;font-size:0\"><table cellpadding=\"0\" cellspacing=\"0\" class=\"es-table-not-adapt es-social\" role=\"presentation\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0;display:none\"><tr><td align=\"center\" valign=\"top\" style=\"padding:0;Margin:0;padding-right:40px\"><img title=\"Facebook\" src=\"https://xsljna.stripocdn.email/content/assets/img/social-icons/logo-black/facebook-logo-black.png\" alt=\"Fb\" width=\"32\" style=\"display:block;border:0;outline:0;text-decoration:none;-ms-interpolation-mode:bicubic\"></td><td align=\"center\" valign=\"top\" style=\"padding:0;Margin:0;padding-right:40px\"><img title=\"Twitter\" src=\"https://xsljna.stripocdn.email/content/assets/img/social-icons/logo-black/twitter-logo-black.png\" alt=\"Tw\" width=\"32\" style=\"display:block;border:0;outline:0;text-decoration:none;-ms-interpolation-mode:bicubic\"></td><td align=\"center\" valign=\"top\" style=\"padding:0;Margin:0;padding-right:40px\"><img title=\"Instagram\" src=\"https://xsljna.stripocdn.email/content/assets/img/social-icons/logo-black/instagram-logo-black.png\" alt=\"Inst\" width=\"32\" style=\"display:block;border:0;outline:0;text-decoration:none;-ms-interpolation-mode:bicubic\"></td><td align=\"center\" valign=\"top\" style=\"padding:0;Margin:0\"><img title=\"Youtube\" src=\"https://xsljna.stripocdn.email/content/assets/img/social-icons/logo-black/youtube-logo-black.png\" alt=\"Yt\" width=\"32\" style=\"display:block;border:0;outline:0;text-decoration:none;-ms-interpolation-mode:bicubic\"></td></tr></table></td></tr><tr><td align=\"center\" style=\"padding:0;Margin:0;padding-bottom:35px\"><p style=\"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:arial,'helvetica neue',helvetica,sans-serif;line-height:18px;color:#333;font-size:12px\">Cosmos CMS &nbsp;© 2023 Cosmos Website Solitions, Inc. All Rights Reserved.</p><p style=\"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:arial,'helvetica neue',helvetica,sans-serif;line-height:18px;color:#333;font-size:12px\">Rancho Cordova, California, USA</p></td></tr><tr><td style=\"padding:0;Margin:0\"><table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" class=\"es-menu\" role=\"presentation\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0\"><tr class=\"links\"><td align=\"center\" valign=\"top\" width=\"33.33%\" style=\"Margin:0;padding-left:5px;padding-right:5px;padding-top:5px;padding-bottom:5px;border:0\"><a target=\"_blank\" href=\"https://www.cosmosws.io\" style=\"-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decoration:none;display:block;font-family:arial,'helvetica neue',helvetica,sans-serif;color:#333;font-size:12px\">Visit Us</a></td><td align=\"center\" valign=\"top\" width=\"33.33%\" style=\"Margin:0;padding-left:5px;padding-right:5px;padding-top:5px;padding-bottom:5px;border:0;border-left:1px solid #ccc\"><a target=\"_blank\" href=\"https://www.cosmosws.io/Privacy\" style=\"-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decoration:none;display:block;font-family:arial,'helvetica neue',helvetica,sans-serif;color:#333;font-size:12px\">Privacy Policy</a></td><td align=\"center\" valign=\"top\" width=\"33.33%\" style=\"Margin:0;padding-left:5px;padding-right:5px;padding-top:5px;padding-bottom:5px;border:0;border-left:1px solid #ccc\"><a target=\"_blank\" href=\"https://www.cosmosws.io/Terms\" style=\"-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decoration:none;display:block;font-family:arial,'helvetica neue',helvetica,sans-serif;color:#333;font-size:12px\">Terms of Use</a></td></tr></table></td></tr></table></td></tr></table></td></tr></table></td></tr></table><table cellpadding=\"0\" cellspacing=\"0\" class=\"es-content\" align=\"center\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0;table-layout:fixed!important;width:100%\"><tr><td class=\"es-info-area\" align=\"center\" style=\"padding:0;Margin:0\"><table class=\"es-content-body\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0;background-color:transparent;width:600px\" bgcolor=\"#FFFFFF\"><tr><td align=\"left\" style=\"padding:20px;Margin:0\"><table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0\"><tr><td align=\"center\" valign=\"top\" style=\"padding:0;Margin:0;width:560px\"><table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" role=\"presentation\" style=\"mso-table-lspace:0;mso-table-rspace:0;border-collapse:collapse;border-spacing:0\"><tr><td align=\"center\" class=\"es-infoblock\" style=\"padding:0;Margin:0;line-height:14px;font-size:12px;color:#262525\"><p style=\"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:arial,'helvetica neue',helvetica,sans-serif;line-height:14px;color:#242323;font-size:12px\">You have received this email as part of our service to you. If you have questions, please let us know by contacting our<a href=\"mailto:notifications@cosmosws.io\">customer service by Email</a>.</p></td></tr></table></td></tr></table></td></tr></table></td></tr></table></td></tr></table></div></body></html>";
}
