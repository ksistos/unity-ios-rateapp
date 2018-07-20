//
//  RateAppHelper.m
//  RateApp
//
//  Created by Dmitry Gayazov on 20.07.2018.
//  Copyright © 2018 Dich Inc. All rights reserved.
//

#import "RateAppHelper.h"
#import <StoreKit/StoreKit.h>

@implementation RateAppHelper
+ (void) requestRate {
    [SKStoreReviewController requestReview];
}
@end

void dich_rateapp_request(void) {
    [RateAppHelper requestRate];
}
